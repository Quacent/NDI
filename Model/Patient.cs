using System;

namespace Model
{
	/// <summary>
	/// id号和时间由数据库决定
	/// 注意可选参数
	/// </summary>
	public class Patient
	{
		enum Sex 
		{
			male = 1, ///男
			female = 2 ///女
		}

		public Patient (string medicalRecord, string name, Sex sex,
			int height, int weight, string sectionName,
			string save1, string save2, string save3, string save4,
			int age = 0, DateTime birthday = DateTime.Now) ///这两个参数是可选参数
		{
			this.medicalRecord = medicalRecord;
			this.name = name;
			this.sex = sex;
			this.height = height;
			this.weight = weight;
			this.sectionName = sectionName;
			this.save1 = save1;
			this.save2 = save2;
			this.save3 = save3;
			this.save4 = save4;
			this.age = age;
			this.birthday = birthday;
		}

		public int id { get; private set; }
		public string medicalRecord { get; set; }
		public string name { get; set; }
		public Sex sex { get; set; }
		public int age { get; set; }
		public DateTime birthday { get; set; }
		public int height { get; set; }
		public int weight { get; set; }
		public string sectionName { get; set; }

		///注意：这些是保留字段
		public string save1 { get; set; }
		public string save2 { get; set; }
		public string save3 { get; set; }
		public string save4 { get; set; }
		public DateTime time { get; private set; }

		public override string ToString ()
		{
			return string.Format ("[Patient: id={0}, medicalRecord={1}, name={2}, sex={3}, age={4}, birthday={5}, height={6}, weight={7}, sectionName={8}, save1={9}, save2={10}, save3={11}, save4={12}, time={13}]", id, medicalRecord, name, sex, age, birthday, height, weight, sectionName, save1, save2, save3, save4, time);
		}
	}
}

