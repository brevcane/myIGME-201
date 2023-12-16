using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_Q3
{
    internal class Program
    {
        // DFS that works with my adjMatrix
        static void DepthFirstSearch(int[,] adjMatrix, int start, bool[] visited)
        {
            visited[start] = true;
            Console.WriteLine(start.ToString());

            for (int i = 0; i < 8; i++)
            {
                if (adjMatrix[start, i] != -1 && !visited[i])
                {
                    DepthFirstSearch(adjMatrix, i, visited);
                }
            }
        }

        // DFS that works with my adjList
        static void DepthFirstSearch(List<(int vertex, int weight)>[] adjList, int start, bool[] visited)
        {
            visited[start] = true;
            Console.WriteLine(start.ToString());

            for (int i = 0; i < adjList[start].Count; i++)
            {
                int neighbor = adjList[start][i].vertex;

                if (!visited[neighbor])
                {
                    DepthFirstSearch(adjList, neighbor, visited);
                }
            }
        }

        // Dijkstras that works with my adjMatrix
        static void DijkstrasShortestPath(int[,] adjMatrix, int start, bool[] visited, int[] distances)
        {
            // initializing my arrays
            for (int i = 0; i < 8; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
            }

            // if this is the first vertex, set the distance to 0
            distances[start] = 0;

            while (!Visited(visited))
            {
                // setting the current vertex to be true for visited
                visited[start] = true;

                // if the vertices are valid, and their distance is longer than the available distance, then update the distance
                for (int i = 0; i < 8; i++)
                {
                    if (!visited[i] && adjMatrix[start, i] != -1)
                    {
                        if (distances[i] > distances[start] + adjMatrix[start, i])
                        {
                            distances[i] = distances[start] + adjMatrix[start, i];
                        }
                    }
                }

                // Finding the shortest vertex
                int minDistance = int.MaxValue;
                int nextVertex = -1;

                for (int i = 0; i < 8; i++)
                {
                    if (!visited[i] && distances[i] < minDistance)
                    {
                        minDistance = distances[i];
                        nextVertex = i;
                    }
                }

                // If there aren't unvisited vertices then print the distance to the green dot (7) and break the loop
                if (nextVertex != -1)
                {
                    start = nextVertex;
                }
                else
                {
                    Console.WriteLine(distances[7].ToString());
                    break;
                }
            }
        }

        // Dijkstras that works with adjList
        static void DijkstrasShortestPath(List<(int vertex, int weight)>[] adjList, int start, bool[] visited, int[] distances)
        {
            // initializing my arrays
            for (int i = 0; i < 8; i++)
            {
                distances[i] = int.MaxValue;
                visited[i] = false;
            }

            // if this is the first vertex, set the distance to 0
            distances[start] = 0;

            while (!Visited(visited))
            {
                // setting the current vertex to be true for visited
                visited[start] = true;

                // for every neighboring vertex update the distance if possible
                foreach ((int neighborVertex, int neighborWeight) in adjList[start])
                {
                    if (!visited[neighborVertex] && distances[neighborVertex] > distances[start] + neighborWeight)
                    {
                        distances[neighborVertex] = distances[start] + neighborWeight;
                    }
                }

                // Finding the shortest vertex
                int minDistance = int.MaxValue;
                int nextVertex = -1;

                for (int i = 0; i < 8; i++)
                {
                    if (!visited[i] && distances[i] < minDistance)
                    {
                        minDistance = distances[i];
                        nextVertex = i;
                    }
                }

                // If there aren't unvisited vertices then print the distance to the green dot (7) and break the loop
                if (nextVertex != -1)
                {
                    start = nextVertex;
                }
                else
                {
                    Console.WriteLine(distances[7].ToString());
                    break;
                }
            }
        }


        // helper method that will tell my dijkstras method when to end by knowing when all the vertices have been visited
        static bool Visited(bool[] visited)
        {
            foreach (bool b in visited)
            {
                if (!b)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            // red will be represented by 0
            // blue will be 1
            // grey will be 2
            // light blue will be 3
            // orange will be 4
            // yellow will be 5
            // pink will be 6
            // green will be 7

            // Adjaceny matrix
            int[,] adjMatrix = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //using -1 to represent areas of the matrix that aren't on the graph
                    adjMatrix[i,j] = -1;
                }
            }

            adjMatrix[0, 1] = 1;
            adjMatrix[0, 2] = 5;
            adjMatrix[1, 5] = 8;
            adjMatrix[1, 3] = 1;
            adjMatrix[3, 1] = 1;
            adjMatrix[3, 2] = 0;
            adjMatrix[2, 3] = 0;
            adjMatrix[2, 4] = 1;
            adjMatrix[4, 6] = 1;
            adjMatrix[6, 5] = 1;
            adjMatrix[5, 7] = 6;

            // Adjacency list
            List<(int vertex, int weight)>[] adjList = new List<(int vertex, int weight)>[8];

            List<(int vertex, int weight)> redList = new List<(int vertex, int weight)>();
            redList.Add((1, 1));
            redList.Add((2, 5));

            List<(int vertex, int weight)> blueList = new List<(int vertex, int weight)>();
            blueList.Add((5, 8));
            blueList.Add((3, 1));

            List<(int vertex, int weight)> greyList = new List<(int vertex, int weight)>();
            greyList.Add((3, 0));
            greyList.Add((4, 1));

            List<(int vertex, int weight)> lightBlueList = new List<(int vertex, int weight)>();
            lightBlueList.Add((1, 1));
            lightBlueList.Add((2, 0));

            List<(int vertex, int weight)> orangeList = new List<(int vertex, int weight)>();
            orangeList.Add((6, 1));

            List<(int vertex, int weight)> yellowList = new List<(int vertex, int weight)>();
            yellowList.Add((7, 6));

            List<(int vertex, int weight)> pinkList = new List<(int vertex, int weight)>();
            pinkList.Add((5, 1));

            List<(int vertex, int weight)> greenList = new List<(int vertex, int weight)>();

            adjList[0] = redList;
            adjList[1] = blueList;
            adjList[2] = greyList;
            adjList[3] = lightBlueList;
            adjList[4] = orangeList;
            adjList[5] = yellowList;
            adjList[6] = pinkList;
            adjList[7] = greenList;

            // Testing DFS for matrix
            bool[] visited = new bool[8];
            Console.WriteLine("Matrix DFS:");
            DepthFirstSearch(adjMatrix, 0, visited);

            // Testing DFS for list
            bool[] visited2 = new bool[8];
            Console.WriteLine("List DFS:");
            DepthFirstSearch(adjList, 0, visited2);
            // This method was only working with it's own unique visited array

            // Testing Dijkstras for matrix
            int[] distances = new int[8];
            Console.WriteLine("Matrix Dijkstras:");
            DijkstrasShortestPath(adjMatrix, 0, visited, distances);

            // Testing Dijkstras for list
            Console.WriteLine("List Dijkstras:");
            DijkstrasShortestPath(adjList, 0, visited, distances);
        }
    }
}
