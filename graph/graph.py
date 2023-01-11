from enum import Enum
from typing import Any, Optional, Dict, List, Callable
import queue

# fifo = queue.Queue() # kolejka
# fifo.put()
# lifo = queue.LifoQueue #stos

# Klasa enumeratora zawierającego typy krawędzi
class EdgeType(Enum):
    directed = 1
    undirected = 2


# Klasa przechowująca węzły grafu: - czyli taki NODE
class Vertex:
    data: Any   # wartość przechowywaną w grafie
    index: int  # numerem pozycji na liście sąsiedztwa

    def __init__(self, data: Any, index: int = 0):
        self.data = data
        self.index = index

    def __repr__(self):
        return f'{self.data}'


# Klasa przechowująca krawędzie grafu:
class Edge:
    source: Vertex
    destination: Vertex
    weight: Optional[float]

    def __init__(self, source: Vertex, destination: Vertex, weight: Optional[float] = None):
        self.source = source
        self.destination = destination
        if weight is not None:
            self.weight = weight

    def __repr__(self):
        return f'{self.destination}'


# Klasa przechowująca strukturę grafu:
class Graph:
    adjacencies: Dict[Vertex, List[Edge]]

    def __init__(self):
        self.adjacencies = {}

    # dodaje nowy wierzchołek do słownika adjacencies jako klucz
    # i pustą listę sąsiedztwa jako wartość
    def create_vertex(self, data: Any) -> Vertex:
        new_vertex = Vertex(data)
        self.adjacencies[new_vertex] = []
        return new_vertex

    # doda nową krawędź od wierzchołka source do wierzchołka destination i umieści ją w słowniku adjacencies
    # w liście sąsiedztwa wierzchołka początkowego tej krawędzi
    def add_directed_edge(self,
                          source: Vertex,
                          destination: Vertex,
                          weight: Optional[float] = None) -> None:
        new_egde = Edge(source, destination, weight)
        self.adjacencies[source].append(new_egde)

    # tworzy krawędź skierowaną od source do destination i na odwrót
    def add_undirected_edge(self,
                            source: Vertex,
                            destination: Vertex,
                            weight: Optional[float] = None) -> None:
        new_edge = Edge(source, destination, weight)
        new_cos = Edge(destination, source, weight)
        self.adjacencies[source].append(new_edge)
        self.adjacencies[destination].append(new_cos)

    # w zależności od typu krawędzi w parametrze edge, doda nową krawędź w grafie
    def add(self, edge: EdgeType,
            source: Vertex,
            destination: Vertex,
            weight: Optional[float] = None) -> None:
        if edge == EdgeType.directed:
            self.add_directed_edge(source, destination, weight)
        elif edge == EdgeType.undirected:
            self.add_undirected_edge(source, destination, weight)

    # wykona operację przechodzenia wszerz po grafie skierowanym.
    # Wykorzystać własną implementację klasy Queue (kolejka, lab 2, zadanie 3)
    def traverse_breadth_first(self, visit: Callable[[Any], None]) -> None:
        visited = []
        key_list = [x for x in self.adjacencies.keys()]
        que = queue.Queue()
        


    # która wykona operację przechodzenia w głąb po grafie skierowanym
    def traverse_depth_first(self, visit: Callable[[Any], None]) -> None:
        pass

    # wyświetli graf wraz ze skierowanymi lub nieskierowanymi krawędziami i ich wagami
    @staticmethod
    def show():






