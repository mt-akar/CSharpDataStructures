﻿using System.Linq;
using Xunit;

namespace AlgorithmHelpers.Tests.DataStructures;

public class GraphTraverseTests
{
    [Fact]
    public void Directed_PrintBfs_5x5Matrix_From0()
    {
        // Arrange
        var graph = GraphsToTest.Directed5By5Matrix();

        // Act
        var traverseList = graph.TraverseBfs(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 4, 2, 5, 8, 3, 6, 9, 12, 7, 10, 13, 11, 14, 15}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintBfs_5x5Matrix_From6()
    {
        // Arrange
        var graph = GraphsToTest.Directed5By5Matrix();

        // Act
        var traverseList = graph.TraverseBfs(6);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {6, 7, 10, 11, 14, 15}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintBfs_BalancedTree_From0()
    {
        // Arrange
        var graph = GraphsToTest.DirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseBfs(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintBfs_BalancedTree_From4()
    {
        // Arrange
        var graph = GraphsToTest.DirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseBfs(4);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {4, 9, 10}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintBfs_Collar_From2()
    {
        // Arrange
        var graph = GraphsToTest.DirectedCollar();

        // Act
        var traverseList = graph.TraverseBfs(2);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {2, 5, 0, 3, 1, 6, 4}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintBfs_Collar_From5()
    {
        // Arrange
        var graph = GraphsToTest.DirectedCollar();

        // Act
        var traverseList = graph.TraverseBfs(5);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {5, 0, 2, 3, 1, 6, 4}, traversedIndices);
    }


    [Fact]
    public void Undirected_PrintBfs_5x5Matrix_From0()
    {
        // Arrange
        var graph = GraphsToTest.Undirected5By5Matrix();

        // Act
        var traverseList = graph.TraverseBfs(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 4, 2, 5, 8, 3, 6, 9, 12, 7, 10, 13, 11, 14, 15}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintBfs_5x5Matrix_From6()
    {
        // Arrange
        var graph = GraphsToTest.Undirected5By5Matrix();

        // Act
        var traverseList = graph.TraverseBfs(6);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {6, 5, 7, 2, 10, 4, 1, 9, 3, 11, 14, 0, 8, 13, 15, 12}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintBfs_BalancedTree_From0()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseBfs(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintBfs_BalancedTree_From4()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseBfs(4);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {4, 1, 9, 10, 0, 3, 2, 7, 8, 5, 6, 11, 12}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintBfs_Collar_From2()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedCollar();

        // Act
        var traverseList = graph.TraverseBfs(2);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {2, 0, 5, 1, 3, 4, 6}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintBfs_Collar_From5()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedCollar();

        // Act
        var traverseList = graph.TraverseBfs(5);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {5, 2, 0, 3, 1, 6, 4}, traversedIndices);
    }


    [Fact]
    public void Directed_PrintDfs_5x5Matrix_From0()
    {
        // Arrange
        var graph = GraphsToTest.Directed5By5Matrix();

        // Act
        var traverseList = graph.TraverseDfs(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 2, 3, 7, 11, 15, 6, 10, 14, 5, 9, 13, 4, 8, 12}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintDfs_5x5Matrix_From6()
    {
        // Arrange
        var graph = GraphsToTest.Directed5By5Matrix();

        // Act
        var traverseList = graph.TraverseDfs(6);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {6, 7, 11, 15, 10, 14}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintDfs_BalancedTree_From0()
    {
        // Arrange
        var graph = GraphsToTest.DirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseDfs(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 3, 7, 8, 4, 9, 10, 2, 5, 11, 12, 6}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintDfs_BalancedTree_From4()
    {
        // Arrange
        var graph = GraphsToTest.DirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseDfs(4);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {4, 9, 10}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintDfs_Collar_From2()
    {
        // Arrange
        var graph = GraphsToTest.DirectedCollar();

        // Act
        var traverseList = graph.TraverseDfs(2);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {2, 5, 0, 1, 3, 6, 4}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintDfs_Collar_From5()
    {
        // Arrange
        var graph = GraphsToTest.DirectedCollar();

        // Act
        var traverseList = graph.TraverseDfs(5);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {5, 0, 1, 3, 6, 4, 2}, traversedIndices);
    }


    [Fact]
    public void Directed_PrintDfsIterative_5x5Matrix_From0()
    {
        // Arrange
        var graph = GraphsToTest.Directed5By5Matrix();

        // Act
        var traverseList = graph.TraverseDfsIterative(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 2, 3, 7, 11, 15, 6, 10, 14, 5, 9, 13, 4, 8, 12}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintDfsIterative_5x5Matrix_From6()
    {
        // Arrange
        var graph = GraphsToTest.Directed5By5Matrix();

        // Act
        var traverseList = graph.TraverseDfsIterative(6);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {6, 7, 11, 15, 10, 14}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintDfsIterative_BalancedTree_From0()
    {
        // Arrange
        var graph = GraphsToTest.DirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseDfsIterative(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 3, 7, 8, 4, 9, 10, 2, 5, 11, 12, 6}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintDfsIterative_BalancedTree_From4()
    {
        // Arrange
        var graph = GraphsToTest.DirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseDfsIterative(4);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {4, 9, 10}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintDfsIterative_Collar_From2()
    {
        // Arrange
        var graph = GraphsToTest.DirectedCollar();

        // Act
        var traverseList = graph.TraverseDfsIterative(2);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {2, 5, 0, 1, 3, 6, 4}, traversedIndices);
    }

    [Fact]
    public void Directed_PrintDfsIterative_Collar_From5()
    {
        // Arrange
        var graph = GraphsToTest.DirectedCollar();

        // Act
        var traverseList = graph.TraverseDfsIterative(5);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {5, 0, 1, 3, 6, 4, 2}, traversedIndices);
    }


    [Fact]
    public void Undirected_PrintDfs_5x5Matrix_From0()
    {
        // Arrange
        var graph = GraphsToTest.Undirected5By5Matrix();

        // Act
        var traverseList = graph.TraverseDfs(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 2, 3, 7, 6, 5, 4, 8, 9, 10, 11, 15, 14, 13, 12}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintDfs_5x5Matrix_From6()
    {
        // Arrange
        var graph = GraphsToTest.Undirected5By5Matrix();

        // Act
        var traverseList = graph.TraverseDfs(6);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {6, 5, 4, 0, 1, 2, 3, 7, 11, 10, 9, 8, 12, 13, 14, 15}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintDfs_BalancedTree_From0()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseDfs(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 3, 7, 8, 4, 9, 10, 2, 5, 11, 12, 6}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintDfs_BalancedTree_From4()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseDfs(4);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {4, 1, 0, 2, 5, 11, 12, 6, 3, 7, 8, 9, 10}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintDfs_Collar_From2()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedCollar();

        // Act
        var traverseList = graph.TraverseDfs(2);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {2, 0, 1, 3, 6, 4, 5}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintDfs_Collar_From5()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedCollar();

        // Act
        var traverseList = graph.TraverseDfs(5);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {5, 2, 0, 1, 3, 6, 4}, traversedIndices);
    }


    [Fact]
    public void Undirected_PrintDfsIterative_5x5Matrix_From0()
    {
        // Arrange
        var graph = GraphsToTest.Undirected5By5Matrix();

        // Act
        var traverseList = graph.TraverseDfsIterative(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 2, 3, 7, 6, 5, 4, 8, 9, 10, 11, 15, 14, 13, 12}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintDfsIterative_5x5Matrix_From6()
    {
        // Arrange
        var graph = GraphsToTest.Undirected5By5Matrix();

        // Act
        var traverseList = graph.TraverseDfsIterative(6);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {6, 5, 4, 0, 1, 2, 3, 7, 11, 10, 9, 8, 12, 13, 14, 15}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintDfsIterative_BalancedTree_From0()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseDfsIterative(0);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {0, 1, 3, 7, 8, 4, 9, 10, 2, 5, 11, 12, 6}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintDfsIterative_BalancedTree_From4()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedBalancedTree();

        // Act
        var traverseList = graph.TraverseDfsIterative(4);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {4, 1, 0, 2, 5, 11, 12, 6, 3, 7, 8, 9, 10}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintDfsIterative_Collar_From2()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedCollar();

        // Act
        var traverseList = graph.TraverseDfsIterative(2);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {2, 0, 1, 3, 6, 4, 5}, traversedIndices);
    }

    [Fact]
    public void Undirected_PrintDfsIterative_Collar_From5()
    {
        // Arrange
        var graph = GraphsToTest.UndirectedCollar();

        // Act
        var traverseList = graph.TraverseDfsIterative(5);

        // Assert
        var traversedIndices = traverseList.Select(v => v.Key).ToArray();
        Assert.Equal(new[] {5, 2, 0, 1, 3, 6, 4}, traversedIndices);
    }
}