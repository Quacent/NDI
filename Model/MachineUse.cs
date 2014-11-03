using System;

namespace DatabaseModel
{
	/// <summary>
	/// id号和starttime、stoptime由数据库负责
	/// </summary>
	public class MachineUse
	{
		public MachineUse (string systemVersion, string softwareVersion,
			string ndiVersion)
		{
			this.systemVersion = systemVersion;
			this.softwareVersion = softwareVersion;
			this.ndiVersion = ndiVersion;
		}

		public int id { get; private set; }
		public string systemVersion { get; set; }
		public string softwareVersion { get; set; }
		public string ndiVersion { get; set; }
		public DateTime startTime { get; }
		public DateTime stopTime { get; private set; }

		public override string ToString ()
		{
			return string.Format ("[MachineUse: id={0}, systemVersion={1}, softwareVersion={2}, ndiVersion={3}, startTime={4}, stopTime={5}]", id, systemVersion, softwareVersion, ndiVersion, startTime, stopTime);
		}
	}
}

