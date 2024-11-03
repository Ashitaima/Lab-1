namespace Task07_03
{
    using Task07_03.Models;
    internal class Program
    {
        static void Main()
        {
            List<Soldier> soldiers = new List<Soldier>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] parts = input.Split();
                string type = parts[0];
                int id = int.Parse(parts[1]);
                string firstName = parts[2];
                string lastName = parts[3];

                switch (type)
                {
                    case "Private":
                        decimal salary = decimal.Parse(parts[4]);
                        soldiers.Add(new Private(id, firstName, lastName, salary));
                        break;

                    case "LeutenantGeneral":
                        salary = decimal.Parse(parts[4]);
                        var general = new LeutenantGeneral(id, firstName, lastName, salary);

                        for (int i = 5; i < parts.Length; i++)
                        {
                            int privateId = int.Parse(parts[i]);
                            var privateSoldier = soldiers.OfType<IPrivate>().FirstOrDefault(p => p.Id == privateId);
                            if (privateSoldier != null)
                            {
                                general.AddPrivate(privateSoldier);
                            }
                        }
                        soldiers.Add(general);
                        break;

                    case "Engineer":
                        salary = decimal.Parse(parts[4]);
                        string corps = parts[5];
                        if (corps == "Airforces" || corps == "Marines")
                        {
                            var engineer = new Engineer(id, firstName, lastName, corps);

                            for (int i = 6; i < parts.Length; i += 2)
                            {
                                string partName = parts[i];
                                int hoursWorked = int.Parse(parts[i + 1]);
                                engineer.AddRepair(new Repair(partName, hoursWorked));
                            }
                            soldiers.Add(engineer);
                        }
                        break;

                    case "Commando":
                        salary = decimal.Parse(parts[4]);
                        corps = parts[5];
                        if (corps == "Airforces" || corps == "Marines")
                        {
                            var commando = new Commando(id, firstName, lastName, corps);

                            for (int i = 6; i < parts.Length; i += 2)
                            {
                                string codeName = parts[i];
                                string state = parts[i + 1];
                                if (state == "inProgress" || state == "Finished")
                                {
                                    commando.AddMission(new Mission(codeName, state));
                                }
                            }
                            soldiers.Add(commando);
                        }
                        break;

                    case "Spy":
                        int codeNumber = int.Parse(parts[4]);
                        soldiers.Add(new Spy(id, firstName, lastName, codeNumber));
                        break;
                }
            }

            foreach (var s in soldiers)
            {
                Console.WriteLine(s);
            }
        }
    }
}
