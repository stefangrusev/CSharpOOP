namespace HighQualityMistakes
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Reflection;
    public class Spy
    {
        public string AnalyzeAccessModifiers(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] classFields = classType
                .GetFields
                (BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            MethodInfo[] classPublicMethods = classType
                .GetMethods
                (BindingFlags.Instance | BindingFlags.Public);

            MethodInfo[] classNonPublicMethods = classType
                .GetMethods
                (BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < classFields.Length; i++)
            {
                FieldInfo field = classFields[i];
                sb.AppendLine($"{field.Name} must be private!");

            }

            foreach (var method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().Trim();

        }
    }
}