namespace Collector
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Reflection;

    public class Spy
    {
        public string AnalyzeAccessModifiers(string investigatedClass)
        {
            Type typeOfClass = Type.GetType(investigatedClass);
            MethodInfo[] methods = typeOfClass.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            var sb = new StringBuilder();

            foreach (var method in methods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (var method in methods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.ReturnType}");
            }

            return sb.ToString().Trim();
        }
    }
}