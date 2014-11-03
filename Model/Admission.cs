using System;

/// <summary>
/// Admission:住院情况
/// </summary>
namespace DatabaseModel
{
	/// <summary>
	/// 时间和id号数据库负责填入
	/// </summary>
	public class Admission
	{
		public Admission (string area, string record, int bedNumber)
		{
			this.area = area;
			this.record = record;
			this.bedNumber = bedNumber;
		}

		public int id { get; private set; }
		public string area { get; set; }
		public string record { get; set; }
		public int bedNumber { get; set; }
		public DateTime time { get; private set; }

		public override string ToString ()
		{
			return string.Format ("[Admission: id={0}, area={1}, record={2}, bedNumber={3}, time={4}]", id, area, record, bedNumber, time);
		}
	}
}

