namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type blackBoxType = typeof(BlackBoxInteger);

            ConstructorInfo constructor = blackBoxType.GetConstructor(
                BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                Type.EmptyTypes,
                null);
            object blackBoxInstance = constructor.Invoke(null);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] commandParts = input.Split('_');
                string methodName = commandParts[0];
                int methodArgument = int.Parse(commandParts[1]);

                MethodInfo method = blackBoxType.GetMethod(
                    methodName,
                    BindingFlags.Instance | BindingFlags.NonPublic);

                method.Invoke(blackBoxInstance, new object[] { methodArgument });

                FieldInfo field = blackBoxType.GetField(
                    "innerValue",
                    BindingFlags.Instance | BindingFlags.NonPublic);
                int fieldValue = (int)field.GetValue(blackBoxInstance);

                Console.WriteLine(fieldValue);
            }
        }
    }
}
