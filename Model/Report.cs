using System;

namespace Model
{
	/// <summary>
	/// id号和time由数据库负责
	/// </summary>
	public class Report
	{
		public Report (string diagnosis, DateTime time)
		{
			this.diagnosis = diagnosis;
			this.time = time;
		}

		public int id { get; private set; }
		public string diagnosis { get; set; }
		public DateTime time { get; private set; }

		public override string ToString ()
		{
			return string.Format ("[Report: id={0}, diagnosis={1}, time={2}]", id, diagnosis, time);
		}
	}
}

