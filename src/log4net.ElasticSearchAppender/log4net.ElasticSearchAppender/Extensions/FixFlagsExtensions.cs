using log4net.Core;

namespace log4net.ElasticSearchAppender.Extensions
{
    public static class FixFlagsExtensions
    {
        public static bool ContainsFlag(this FixFlags flagsEnum, FixFlags flag)
        {
            return (flagsEnum & flag) != 0;
        }
    }
}