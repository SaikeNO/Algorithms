class Edge
{
    public int Speed { get; set; }
    private int Lenght { get; set; }

    public Edge(int speed, int length)
    {
        Lenght = length;
        Speed = speed;
    }

    public int CalculateTime()
    {
        return (Lenght * 60 / Speed);
    }
}

class Graph
{
    Dictionary<int, Dictionary<int, Edge>> graph = new();
    public Graph(string[] lines)
    {
        foreach (var line in lines) // budowanie grafu
        {
            var connectionInfo = line.Split();
            char action = connectionInfo[1][0];
            int city1 = int.Parse(connectionInfo[2]);
            int city2 = int.Parse(connectionInfo[3]);
            int speed = int.Parse(connectionInfo[4]);

            if (action == 'm')
            {
                graph[city1][city2].Speed = speed;
            }
            else
            {
                int length = int.Parse(connectionInfo[5]);
                Edge edge = new Edge(speed, length);

                Add(city1, city2, edge);
                Add(city2, city1, edge);
            }
        }
    }

    public void Add(int city1, int city2, Edge edge)
    {
        if (!graph.ContainsKey(city1))
            graph[city1] = new Dictionary<int, Edge>();

        graph[city1][city2] = edge;
    }

    public Dictionary<int, int> Dijkstra(int start, int end)
    {
        Dictionary<int, int> times = new();
        Dictionary<int, bool> visited = new();
        PriorityQueue<int, int> pq = new();

        foreach (var node in graph.Keys)
        {
            visited[node] = false;
            times[node] = int.MaxValue;
            pq.Enqueue(node, int.MaxValue);
        }

        times[start] = 0;
        pq.Enqueue(start, 0);

        while (pq.Count > 0)
        {
            var node = pq.Dequeue();

            if (visited[node]) continue;

            visited[node] = true;

            foreach (var (index, neighbour) in graph[node])
            {
                if (times[node] == int.MaxValue) continue;

                int newDistance = times[node] + neighbour.CalculateTime();

                if (newDistance < times[index])
                {
                    times[index] = index == end ? newDistance : newDistance + 5;
                    pq.Enqueue(index, newDistance);

                }
            }
        }

        return times;
    }

    public bool Contains(int city)
    {
        return graph.ContainsKey(city);
    }
}

class Program
{
    static void Main()
    {
        var inputLines = File.ReadAllLines("../../../duzy3.txt");

        var input = inputLines[0].Split();
        int n = int.Parse(input[0]); // liczba miast
        int m = int.Parse(input[1]); // liczba budowanych/modernizowanych odcinków
        int z = int.Parse(input[2]); // liczba zapytań
        string[] builindLines = new string[m];

        for (int i = 1; i <= m; i++)
        {
            builindLines[i - 1] = inputLines[i];
        }

        for (int i = m + 1; i <= z + m; i++) // zapytania
        {
            var line = inputLines[i].Split();
            int city1 = int.Parse(line[0]);
            int city2 = int.Parse(line[1]);
            int time = int.Parse(line[2]);

            //binary search O(logn)
            int left = 0;
            int right = m - 1;
            string date = "NIE";

            while (left < right)
            {
                int mid = (right + left) / 2;
                var graph = new Graph(builindLines.Take(mid + 1).ToArray());
                var times = graph.Dijkstra(city1, city2); // O(n + m*logn)

                if (graph.Contains(city2) && times[city2] <= time)
                {
                    right = mid;

                    date = builindLines[mid].Split()[0];
                }
                else
                {
                    left = mid + 1;
                }

            }

            Console.WriteLine(date);
        }
    }
}

