using SwissAcademic.Citavi;
using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace ExportToMySQL
{
    static class CitaviTypeConverter
    {
        public static string doConvert(object obj)
        {
            string ret = "";
            if (obj == null)
                ret = "";
            else if (obj is string)
                ret = (string)obj;
            else if (obj is double)
                ret = ((double)obj).ToString();
            else if (obj is int)
                ret = ((int)obj).ToString();
            else if (obj is bool)
                ret = ((bool)obj).ToString();
            else if (obj is Keyword)
                ret = ((Keyword)obj).FullName;
            else if (obj is KnowledgeItem)
                ret = ((KnowledgeItem)obj).Text;
            else if (obj is PersonRole)
                ret = ((PersonRole)obj).ToString();
            else if (obj is Person)
                ret = ((Person)obj).LastName + ", " + Regex.Replace(((Person)obj).FirstName, @"(\w)\w+[^.]", @"$1.");
            else if (obj is Location)
                ret = ((Location)obj).FullName;
            else if (obj is Category)
                ret = ((Category)obj).FullName;
#if !CITAVI4
            else if (obj is SwissAcademic.Citavi.Group)
                ret = ((SwissAcademic.Citavi.Group)obj).FullName;
            else if (obj is SwissAcademic.PageCount)
                ret = ((SwissAcademic.PageCount)obj).ToString();
            else if (obj is SwissAcademic.PageRange)
                ret = ((SwissAcademic.PageRange)obj).ToString();
            else if (obj is SwissAcademic.PageNumber)
                ret = ((SwissAcademic.PageNumber)obj).ToString();
#endif
            else if (obj is Periodical)
                ret = ((Periodical)obj).FullName;
            else if (obj is Reference)
                ret = ((Reference)obj).Title;
            else if (obj is Isbn)
                ret = ((Isbn)obj).Value;
            else if (obj is Int16)
                ret = ((Int16)obj).ToString();
            else if (obj is UpdateType)
                ret = ((UpdateType)obj).ToString();
            else if (obj is Publisher)
                ret = ((Publisher)obj).FullName;
            else if (obj is ReferenceType)
                ret = ((ReferenceType)obj).Name;
            else if (obj is SeriesTitle)
                ret = ((SeriesTitle)obj).FullName;
            else if (obj is TaskItem)
                ret = ((TaskItem)obj).FullName;
            else if (obj is DateTime)
                ret = ((DateTime)obj).ToString();
            else if (obj is Guid)
                ret = ((Guid)obj).ToString();
            else if (obj is TrackingState)
                ret = ((TrackingState)obj).ToString();
            else if (obj is Project)
                ret = ((Project)obj).Name;
            else if (obj is Project)
                ret = ((Project)obj).Name;
            else if (obj is IEnumerable)
            {
                foreach (object item in (IEnumerable)obj)
                {
                    if (item == null)
                        continue;
                    if (ret != "")
                        ret += "; ";
                    ret += doConvert(item);
                }
            }
            else
                ret = obj.GetType().ToString();
            return ret;
        }
    }
}
