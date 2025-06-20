# Small World Phenomenon
A console application that calculates the degree of separation between actors based on their co-appearances in movies.

## Description
This project simulates the "six degrees of separation" concept in the film industry.
It finds the shortest connection path between any two actors using movie data.

## Features
- Parses input of movies and actors
- Builds a graph with actors as nodes and movies as edges
- Calculates:
  - Degree of separation (BFS)
  - Shortest path using Dijkstra’s algorithm

## Technologies Used
- C++
- STL (map, vector, queue, priority_queue)
- Algorithms: BFS, Dijkstra
