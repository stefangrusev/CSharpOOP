namespace Stealer
{
    using System;
    using System.Text;
    using System.Reflection;
    public class Spy
    {
        public string RevealPrivateMethods(string investigatedClass)
        {
            Type typeOfClass = Type.GetType(investigatedClass);
            MethodInfo[] privateMethods = typeOfClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            Console.WriteLine($"All Private Methods of Class: {typeOfClass.FullName}");
            Console.WriteLine($"Base class: {typeOfClass.BaseType.Name}");

            var sb = new StringBuilder();

            for (int i = 0; i < privateMethods.Length; i++)
            {
                MethodInfo method = privateMethods[i];
                sb.AppendLine(method.Name);
            }

            return sb.ToString().Trim();
        }
    }
}