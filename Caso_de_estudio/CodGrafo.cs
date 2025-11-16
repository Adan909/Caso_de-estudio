using System.Collections.Generic;
using System.Drawing;

public class CodGrafo
{
    public Dictionary<string, List<string>> Ady = new Dictionary<string, List<string>>();
    public Dictionary<string, Point> Pos = new Dictionary<string, Point>();

    public void AgregarNodo(string n, Point p)
    {
        Ady[n] = new List<string>();
        Pos[n] = p;
    }

    public void AgregarArista(string a, string b)
    {
        if (!Ady[a].Contains(b)) Ady[a].Add(b);
        if (!Ady[b].Contains(a)) Ady[b].Add(a);
    }
}


    


