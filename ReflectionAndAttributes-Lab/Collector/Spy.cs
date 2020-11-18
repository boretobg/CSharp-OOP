using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string CollectGettersAndSetters(string className)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Type classType = Type.GetType(className);
            var classMethods = classType.GetMethods(BindingFlags.Public | 
                BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var method in classMethods.Where(m => m.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} will return {method.ReturnType}");

            }
            foreach (var method in classMethods.Where(m => m.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
            return stringBuilder.ToString().Trim();
        }
        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);
            var classMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"All Private Methods of Class: {className}");
            stringBuilder.AppendLine($"Base Class: {classType.BaseType.Name}");


            foreach (var method in classMethods)
            {
                stringBuilder.AppendLine(method.Name);
            }

            return stringBuilder.ToString().Trim();
        }

        public string AnalyzeAcessModifiers(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass); 
            var classField = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (FieldInfo field in classField)
            {
                stringBuilder.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be public!");
            }
            foreach (MethodInfo method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be private!");
            }

            return stringBuilder.ToString().Trim();
        }

        public string StealFieldInfo(string className, params string[] fieldsNames)
        {
            Type classType = Type.GetType(className);
            var classFields = classType.GetFields(
                BindingFlags.Instance | BindingFlags.Static | 
                BindingFlags.NonPublic | BindingFlags.Public);
            StringBuilder stringBuilder = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            stringBuilder.AppendLine($"Class under investigation: {className}");

            foreach (FieldInfo field in classFields.Where(f => fieldsNames.Contains(f.Name)))
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
