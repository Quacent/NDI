using System;

/// <summary>
/// User: 操作者
/// </summary>
namespace Model
{
	/// <summary>
	/// id号由数据库负责
	/// </summary>
	public class User
	{
		enum levelOption : byte
		{
			chiefDoctor = 1, ///主任医师
			associateChiefDoctor = 2, ///副主任医师
			attendingDoctor = 3, ///主治医师
			residentDoctor = 4, ///住院医生
			doctor = 5, ///医生
			professor = 6, ///教授
			teacher = 7, ///老师
			student = 8 ///学生
		}

		public User (string name, levelOption level, bool isAdmin)
		{
			this.name = name;
			this.level = level;
			this.isAdmin = isAdmin;
		}

		public int id { get; private set; }
		public string name { get; set; }
		public levelOption level { get; set; }
		public bool isAdmin { get; set; }

		public override string ToString ()
		{
			return string.Format ("[User: id={0}, name={1}, level={2}, isAdmin={3}]", id, name, level, isAdmin);
		}
	}
}

