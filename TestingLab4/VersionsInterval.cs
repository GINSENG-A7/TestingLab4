using System;
using System.Collections.Generic;
using System.Text;

namespace TestingLab4
{
    class VersionsInterval
    {
        const string maxVersionString = "2147483647.2147483647.2147483647";
        const string minVersionString = "0.0.0";
        public Versions leftVersion { get; set; }
        public Versions rightVersion { get; set; }
        private static string sign = "";
        public VersionsInterval(string versionsInterval)
        {
            if (IsCorrect(versionsInterval) == true)
            {
                string noSingsVersions = versionsInterval.Remove(0, sign.Length);
                Versions tempVersion = new Versions(noSingsVersions);
                switch (sign)
                {
                    case (">"):
                        leftVersion = tempVersion;
                        leftVersion.Patch += 1;
                        rightVersion = new Versions(maxVersionString);
                        break;
                    case (">="):
                        leftVersion = tempVersion;
                        rightVersion = new Versions(maxVersionString);
                        break;
                    case ("<"):
                        rightVersion = tempVersion;
                        rightVersion.Patch -= 1;
                        leftVersion = new Versions(minVersionString);
                        break;
                    case ("<="):
                        rightVersion = tempVersion;
                        leftVersion = new Versions(minVersionString);
                        break;
                    case ("="):
                        leftVersion = tempVersion;
                        rightVersion = tempVersion;
                        break;
                }
                sign = "";
            }
            else
            {
                throw new ArgumentException("Недопустимый знак при объявлении версии");
            }
        }
        public VersionsInterval(Versions leftVersion, Versions rightVersion)
        {
            if (leftVersion < rightVersion)
            {
                this.leftVersion = leftVersion;
                this.rightVersion = rightVersion;
            }
            else
            {
                throw new ArgumentException("Начало верисионного интервала должно быть меньше его конца");
            }
        }

        private static bool IsCorrect(string versionsInterval)
        {
            foreach (char c in versionsInterval)
            {
                if (c == '>' || c == '<' || c == '=')
                {
                    sign += c;
                }
                else
                {
                    break;
                }
            }
            if (sign == ">" || sign == ">=" || sign == "<" || sign == "<=" || sign == "=")
            {
                if (versionsInterval.Split('.').Length == 3)
                {
                    return true;
                }
            }
            return false;
		}
        public static VersionsInterval[] Intersection(VersionsInterval version1, VersionsInterval version2)
        {
            if (version1.leftVersion <= version2.leftVersion)
            {
                if (version1.rightVersion >= version2.leftVersion)
                {
                    return new VersionsInterval[] { new VersionsInterval(version1.leftVersion, version2.rightVersion) };
                }
                if (version1.rightVersion >= version2.rightVersion)
                {
                    return new VersionsInterval[] { version1 };
                }
                if (version1.rightVersion <= version2.rightVersion)
                {
                    return new VersionsInterval[] { version1, version2 };
                }
            }
            if (version1.leftVersion >= version2.leftVersion)
            {
                if (version2.rightVersion >= version1.leftVersion)
                {
                    return new VersionsInterval[] { new VersionsInterval(version2.leftVersion, version1.rightVersion) };
                }
                if (version2.rightVersion >= version1.rightVersion)
                {
                    return new VersionsInterval[] { version2 };
                }
                if (version1.rightVersion >= version2.rightVersion)
                {
                    return new VersionsInterval[] { version2, version1 };
                }
            }
            return new VersionsInterval[0];
        }
        public static VersionsInterval[]? Union(VersionsInterval version1, VersionsInterval version2)
        {
            if (version1.leftVersion <= version2.leftVersion)
            {
                if (version1.rightVersion >= version2.leftVersion)
                {
                    return new VersionsInterval[] { new VersionsInterval(version2.leftVersion, version1.rightVersion) };
                }
                if (version1.rightVersion >= version2.rightVersion)
                {
                    return new VersionsInterval[] { version1 };
                }
                return null;
            }
            if (version2.leftVersion <= version1.leftVersion)
            {
                if (version2.rightVersion >= version1.leftVersion)
                {
                    return new VersionsInterval[] { new VersionsInterval(version2.leftVersion, version2.rightVersion) };
                }
                if (version2.rightVersion >= version1.rightVersion)
                {
                    return new VersionsInterval[] { version2 };
                }
                return null;
            }
            return new VersionsInterval[0];
        }
        public override string ToString()
        {
            return $"from {this.leftVersion.ToString()} to {this.rightVersion.ToString()}";
        }
    }
}
