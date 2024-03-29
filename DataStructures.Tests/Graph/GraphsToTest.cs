﻿using System.Collections.Generic;
using DataStructures.Graph;

namespace Graph.Tests;

public class GraphsToTest
{
    public static DirectedGraph<string> Directed5By5Matrix()
    {
        var edges = new List<(int, int)>();

        // Add horizontal edges
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                var edge = (i * 4 + j, i * 4 + j + 1);
                edges.Add(edge);
            }
        }

        // Add vertical edges
        for (int j = 0; j <= 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                var edge = (i * 4 + j, i * 4 + j + 4);
                edges.Add(edge);
            }
        }

        return new DirectedGraph<string>(edges);
    }

    public static DirectedGraph<string> DirectedBalancedTree()
    {
        var edges = new List<(int, int)>();

        for (int i = 0; i <= 5; i++)
        {
            edges.Add((i, 2 * i + 1));
            edges.Add((i, 2 * i + 2));
        }

        return new DirectedGraph<string>(edges);
    }

    public static DirectedGraph<string> DirectedCollar()
    {
        var graph = new DirectedGraph<string>();
        // Add 7 nodes
        for (int i = 0; i < 7; i++)
            graph.AddVertex(i);

        var edges = new List<(int From, int To)>
        {
            (0, 1),
            (0, 2),
            (0, 3),
            (1, 3),
            (1, 4),
            (1, 6),
            (2, 5),
            (3, 6),
            (5, 0),
            (5, 2),
            (5, 3),
            (6, 1),
            (6, 4),
        };

        return new DirectedGraph<string>(edges);
    }

    public static DirectedGraph<string> DirectedConnected531()
    {
        var edges = new List<(int, int)>();

        // Complete 5
        for (int i = 0; i <= 3; i++)
        {
            for (int j = i + 1; j <= 4; j++)
            {
                edges.Add((i, j));
                edges.Add((j, i));
            }
        }

        // Complete 3
        edges.Add((5, 6));
        edges.Add((6, 5));
        edges.Add((6, 7));
        edges.Add((7, 6));
        edges.Add((7, 5));
        edges.Add((5, 7));

        var graph = new DirectedGraph<string>(edges);
        graph.AddVertex(8);

        return graph;
    }

    public static DirectedGraph<string> DirectedCycle10000()
    {
        var edges = new List<(int, int)>();

        for (int i = 0; i < 9999; i++)
            edges.Add((i, i + 1));
        edges.Add((9999, 0));

        return new DirectedGraph<string>(edges);
    }

    public static DirectedGraph<string> DirectedWindow()
    {
        var edges = new List<(int, int)>
        {
            (0, 0),
            (0, 1),
            (0, 1),
            (0, 3),
            (0, 5),
            (2, 2),
            (2, 3),
            (2, 3),
            (2, 5),
            (4, 4),
            (4, 5),
            (4, 5),
        };

        return new DirectedGraph<string>(edges);
    }

    public static DirectedGraph<string> DirectedStar()
    {
        var edges = new List<(int, int)>();

        for (int i = 1; i <= 5; i++)
            edges.Add((0, i));

        return new DirectedGraph<string>(edges);
    }

    public static DirectedGraph<string> DirectedInboundStar()
    {
        var edges = new List<(int, int)>();

        for (int i = 1; i <= 5; i++)
            edges.Add((i, 0));

        return new DirectedGraph<string>(edges);
    }

    public static DirectedGraph<string> DirectedDoubleTick()
    {
        return new DirectedGraph<string>(new Dictionary<int, Vertex<string>>
        {
            [0] = new(null, 1, 3),
            [1] = new(null, 2),
            [2] = new(),
            [3] = new(),
            [4] = new(null, 5, 7),
            [5] = new(null, 6),
            [6] = new(),
            [7] = new(),
        });
    }


    public static UndirectedGraph<string> Undirected5By5Matrix()
    {
        var edges = new List<(int, int)>();

        // Add horizontal edges
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                var edge = (i * 4 + j, i * 4 + j + 1);
                edges.Add(edge);
            }
        }

        // Add vertical edges
        for (int j = 0; j <= 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                var edge = (i * 4 + j, i * 4 + j + 4);
                edges.Add(edge);
            }
        }

        return new UndirectedGraph<string>(edges);
    }

    public static UndirectedGraph<string> UndirectedBalancedTree()
    {
        var edges = new List<(int, int)>();

        for (int i = 0; i <= 5; i++)
        {
            edges.Add((i, 2 * i + 1));
            edges.Add((i, 2 * i + 2));
        }

        return new UndirectedGraph<string>(edges);
    }

    public static UndirectedGraph<string> UndirectedCollar()
    {
        var edges = new List<(int, int)>
        {
            (0, 1),
            (0, 2),
            (0, 3),
            (1, 3),
            (1, 4),
            (1, 6),
            (2, 5),
            (3, 6),
            (5, 0),
            (5, 2),
            (5, 3),
            (6, 1),
            (6, 4),
        };

        return new UndirectedGraph<string>(edges);
    }

    public static UndirectedGraph<string> UndirectedConnected531()
    {
        var edges = new List<(int, int)>();

        // Complete 5
        for (int i = 0; i <= 3; i++)
        {
            for (int j = i + 1; j <= 4; j++)
            {
                edges.Add((i, j));
            }
        }

        // Complete 3
        edges.Add((5, 6));
        edges.Add((6, 7));
        edges.Add((7, 5));

        var graph = new UndirectedGraph<string>(edges);
        graph.AddVertex(8);

        return graph;
    }

    public static UndirectedGraph<string> UndirectedCycle10000()
    {
        var edges = new List<(int, int)>();

        for (int i = 0; i < 9999; i++)
            edges.Add((i, i + 1));
        edges.Add((9999, 0));

        return new UndirectedGraph<string>(edges);
    }

    public static UndirectedGraph<string> UndirectedWindow()
    {
        var edges = new List<(int, int)>
        {
            (0, 0),
            (0, 1),
            (0, 1),
            (0, 3),
            (0, 5),
            (2, 2),
            (2, 3),
            (2, 3),
            (2, 5),
            (4, 4),
            (4, 5),
            (4, 5),
        };

        return new UndirectedGraph<string>(edges);
    }

    public static UndirectedGraph<string> UndirectedStar()
    {
        var edges = new List<(int, int)>();

        for (int i = 1; i <= 5; i++)
            edges.Add((0, i));

        return new UndirectedGraph<string>(edges);
    }

    public static UndirectedGraph<string> UndirectedDoubleTick()
    {
        var edges = new List<(int, int)>
        {
            (0, 1),
            (1, 2),
            (0, 3),
            (4, 5),
            (5, 6),
            (4, 7),
        };

        return new UndirectedGraph<string>(edges);
    }
}