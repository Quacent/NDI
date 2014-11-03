using System;

namespace DatabaseModel
{
	/// <summary>
	/// id号和time由数据库负责
	/// </summary>
	public class Operation
	{
		enum SideDirection : byte
		{
			left = 1,   //左
			right = 2,  //右
			both = 3    //左右
		}

		public Operation (string project, string bodyPart, string nerve,
			string muscle, string stimulate, string record, string reference,
			SideDirection sideDirection)
		{
			this.project = project;
			this.bodyPart = bodyPart;
			this.nerve = nerve;
			this.muscle = muscle;
			this.stimulate = stimulate;
			this.record = record;
			this.reference = reference;
			this.sideDirection = sideDirection;
		}

		public int id { get; private set; }
		public string project { get; set; }
		public string bodyPart { get; set; }
		public string nerve { get; set; }
		public string muscle { get; set; }
		public string stimulate { get; set; }
		public string record { get; set; }
		public string reference { get; set; }
		public SideDirection sideDirection { get; set; }
		public DateTime time { get; private set; }

		public override string ToString ()
		{
			return string.Format ("[Operation: id={0}, project={1}, bodyPart={2}, nerve={3}, muscle={4}, stimulate={5}, record={6}, reference={7}, sideDirection={8}, time={9}]", id, project, bodyPart, nerve, muscle, stimulate, record, reference, sideDirection, time);
		}
	}
}