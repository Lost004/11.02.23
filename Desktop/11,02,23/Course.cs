using System;
using System.Collections.Generic;
using System.Text;

namespace _11_02_23
{
	internal class Course
	{
		public Group[] groups = new Group[0];
		public void AddGroup(Group grp)
		{
			Array.Resize(ref groups, groups.Length + 1);
			groups[groups.Length - 1] = grp;
		}
		public Group[] GetGroupsByPointRange(double minPoint,double maxPoint)
		{
			Group[] wantedGroup = new Group[0];
			for (int i = 0; i < wantedGroup.Length; i++)
			{
				if (wantedGroup[i].AvgPoint>=minPoint && wantedGroup[i].AvgPoint <= maxPoint)
				{
					Array.Resize(ref wantedGroup, wantedGroup.Length + 1);
					wantedGroup[wantedGroup.Length - 1] = groups[i];
				}
			}
			return wantedGroup;
		}
		public Group[] GetGroupByNo(string no)
		{
			Group[] getgroupbyno = new Group[0];
			bool isExist = false;
				for (int i = 0; i <getgroupbyno.Length; i++)
			{
				if (getgroupbyno[i].ToString().Contains(no))
				{
					isExist = true;
				}
				if(isExist == false)
				{
					Console.WriteLine("Yanlis qrup. Bele bir qrup yoxdur!");
				}
			}
			return getgroupbyno;
		}
		public Group[] Search(string search)
		{
			Group[] search1 = new Group[0];
			bool isExist = false;

			for (int i = 0; i < groups.Length; i++)
			{
				if (groups[i].ToString().Contains(search))
				{
					Console.WriteLine(groups[i]);
					isExist = true;
				}
				if(isExist == false)
				{
					Console.WriteLine("Bele bir qrup yoxdur");
				}
			}
			return search1;
		}
	}
}
