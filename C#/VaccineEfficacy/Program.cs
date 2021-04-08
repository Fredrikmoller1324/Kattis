using System;

namespace VaccineEfficacy
{
    class Program
    {
        static void Main(string[] args)
        {

            double totPeopleVaccinated = 0;
            double totPeopleNotVaccinated = 0;

            double strain_A_VaccInfected = 0;
            double strain_B_VaccInfected = 0;
            double strain_C_VaccInfected = 0;

            double strain_A_Not_VaccInfected = 0;
            double strain_B_Not_VaccInfected = 0;
            double strain_C_Not_VaccInfected = 0;

            
            

            int amountOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfPeople; i++)
            {
                string trialPerson = Console.ReadLine();

                if (trialPerson[0] == 'Y')
                {
                    totPeopleVaccinated++;

                    if (trialPerson[1] == 'Y')
                    {
                        strain_A_VaccInfected++;
                    }

                    if (trialPerson[2] == 'Y')
                    {
                        strain_B_VaccInfected++;
                    }

                    if (trialPerson[3] == 'Y')
                    {
                        strain_C_VaccInfected++;
                    }

                }
                else
                {
                    totPeopleNotVaccinated++;
                    if (trialPerson[1] == 'Y')
                    {
                        strain_A_Not_VaccInfected++;
                    }
                    if (trialPerson[2] == 'Y')
                    {
                        strain_B_Not_VaccInfected++;
                    }
                    if (trialPerson[3] == 'Y')
                    {
                        strain_C_Not_VaccInfected++;
                    }
                }
            }

            double infect_Rate_A_Vacc = strain_A_VaccInfected / totPeopleVaccinated;
            double infect_Rate_A_Not_Vacc = strain_A_Not_VaccInfected / totPeopleNotVaccinated;

            double infect_Rate_B_Vacc = strain_B_VaccInfected / totPeopleVaccinated;
            double infect_Rate_B_Not_Vacc = strain_B_Not_VaccInfected / totPeopleNotVaccinated;

            double infect_Rate_C_Vacc = strain_C_VaccInfected / totPeopleVaccinated;
            double infect_Rate_C_Not_Vacc = strain_C_Not_VaccInfected / totPeopleNotVaccinated;


            double efficacy_A = 1 - (infect_Rate_A_Vacc / infect_Rate_A_Not_Vacc);
            double efficacy_B = 1 - (infect_Rate_B_Vacc / infect_Rate_B_Not_Vacc);
            double efficacy_C = 1 - (infect_Rate_C_Vacc / infect_Rate_C_Not_Vacc);

            if (efficacy_A <= 0)
            {
                Console.WriteLine("Not Effective");
            }
            else
            {
                Console.WriteLine((efficacy_A * 100).ToString("N6").Replace(',', '.'));
            }
            if (efficacy_B <= 0)
            {
                Console.WriteLine("Not Effective");
            }
            else
            {
                Console.WriteLine((efficacy_B * 100).ToString("N6").Replace(',', '.'));
            }
            if (efficacy_C <= 0)
            {
                Console.WriteLine("Not Effective");
            }
            else
            {
                Console.WriteLine((efficacy_C * 100).ToString("N6").Replace(',','.'));
            }

        }
    }
}
