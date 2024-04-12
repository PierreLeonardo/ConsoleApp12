using System;
RegistrarAsignaturas n = new RegistrarAsignaturas();
n.adquiDatos();
n.mostrarNotas();
public class RegistrarAsignaturas
{
    Dictionary<string, int> asig_cal = new Dictionary<string, int>();
    int ind = 0, num_asig = 0;
    string grad;
    public void adquiDatos()
    {
        while (true)
        {
            Console.Write("Introduzca la asignatura: ");

            string asig = Console.ReadLine();
            Console.Write("Introduzca su correspondiente califiacación: ");
            string cal = Console.ReadLine();

            if ((cal.Trim().Length == 0) && (asig.Trim().Length == 0))
			{ Console.WriteLine("Prosigamos con el proceso"); break; }

            else if (cal.Trim().Length == 0 || asig.Trim().Length == 0)
			{ Console.WriteLine("No introdujo un valor clave. Vuelva a intentarlo"); }

            else if (cal.Contains("."))
            { Console.WriteLine("La calificación es incorrecta"); }

            else if (int.Parse(cal) < -1 || int.Parse(cal) > 101)

            { Console.WriteLine("La calificación es incorrecta"); }
            else
            {
                asig_cal.Add(asig, int.Parse(cal));
                num_asig++;
            }
        }
    }
    public void mostrarNotas()
    {
        for (int lim = 0; lim < num_asig; lim++)
        {
            Console.WriteLine("Asignatura: " + asig_cal.Keys.ElementAt(lim) + " -> Calificación: " + asig_cal.Values.ElementAt(lim));
        }
    }
    public void promediar()
    {
        for (int lim = 0; lim < num_asig; lim++)
        {
            ind += asig_cal.Values.ElementAt(lim);
        }
        ind /= num_asig;
        ind = 400 / ind;

    }
    public void enseProm()
    {
        switch (ind)
        {
            case < 60:
                grad = "F";
                break;
            case < 70:
                grad = "D";
                break;
            case < 75:
                grad = "C-";
                break;
            case < 80:
                grad = "C";
                break;
            case < 85:
                grad = "B-";
                break;
            case < 90:
                grad = "B";
                break;
            default:
                grad = "A";
                break;
                Console.WriteLine("Su índice es: " + grad);
        }
    }
}
