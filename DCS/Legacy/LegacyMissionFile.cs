using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;




namespace CPT.API.IO.Serialization.DCS.Legacy {
	
	public partial class LegacyMissionFile {

		[DataMember(Name = "mission")]
		public MissionTable Mission { get; set; }

		[DataMember(Name = "options")]
		public OptionsTable Options { get; set; }

		[DataMember(Name = "theatre")]
		public string Theatre { get; set; }

		[DataMember(Name = "warehouses")]
		public WarehousesTable Warehouses { get; set; }




		public virtual ZipArchive CreateArchive(Stream stream, Encoding encoding = null, CompressionLevel compressionLevel = CompressionLevel.Optimal) {
			ZipArchive archive = null;

			if (encoding == null) {
				encoding = Encoding.UTF8;
			}

			try {
				archive = new ZipArchive(stream, ZipArchiveMode.Create);

				ZipArchiveEntry entry;
				DataMemberAttribute attr;
				foreach (PropertyInfo property in this.GetType().GetProperties()) {
					attr = property.GetCustomAttribute<DataMemberAttribute>(false);
					if (attr?.Name == null) {
						// TODO: log
						continue;
					}

					entry = archive.CreateEntry(attr.Name, compressionLevel);
					using (Stream entry_stream = entry.Open()) {
						byte[] write = null;

						if (property.PropertyType.Equals(typeof(string))) {
							write = encoding.GetBytes((string)property.GetValue(this));
						} else if (property.PropertyType.IsAssignableTo(typeof(LuaTable))) {
							write = ((LuaTable)property.GetValue(this)).Serialize(encoding);
						}

						if (write == null) {
							throw new InvalidOperationException("Serialization failure or unexpected property type encountered.");
						}

						entry_stream.Write(write, 0, write.Length);
					}
				}
			} catch {
				archive?.Dispose();

				throw;
			}

			return archive;
		}

	}

}
