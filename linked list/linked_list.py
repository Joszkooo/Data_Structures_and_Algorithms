from typing import Any


class Node:
    value: Any
    next: 'Node'

    def __init__(self, value: Any = None, next: 'Node' = None) -> None:
        self.value = value
        self.next = next

    def __repr__(self) -> str:
        return f'{self.value}'


class LinkedList:
    head: Node
    tail: Node

    def __init__(self, head: Node = None, tail: Node = None):
        self.head = head
        self.tail = tail

    # umieszcza nowy węzeł na początku listy
    def push(self, value: Any) -> None:
        new_node = Node(value)
        if self.head is None:
            self.head = new_node
            self.tail = new_node
            return
        self.tail.next = new_node
        self.head.next = new_node

    # umieszcza nowy węzeł na końcu listy
    def append(self, value: Any) -> None:
        pass

    # zwraca węzeł znajdujący się na wskazanej pozycji
    def node(self, at: int) -> Node:
        curr = self.head
        if len(self) < at:
            print('The list is shorter than the given node position.')

        for i in range(at):
            curr = curr.next
        return curr

    # wstawia nowy węzeł tuż za węzłem wskazanym w parametrze
    def insert(self, value: Any, after: Node) -> None:
        pass

    # usuwa pierwszy element z listy i go zwróci
    def pop(self) -> Any:
        pass

    # usuwa ostatni element z listy i go zwróci
    def remove_last(self) -> Any:
        pass

    # usuwa z listy następnik węzła przekazanego w parametrze
    def remove(self, after: Node) -> Any:
        if self.head is None:
            print('No elements to remove!')
            return None
        after.next = after.next.next

    # wywołana na obiekcie listy zawierającym 2 elementy [0, 1] wyświetli na ekranie "0 -> 1"
    def __repr__(self):
        if self.head is None:
            return 'Empty list!'
        curr = self.head
        txt = f''

        while curr:
            if curr.next is None:
                txt += str(curr.value)
            else:
                txt += str(curr.value) + '->'
            curr = curr.next
        return txt

    # wywołana na obiekcie listy zwróci jej długość
    def __len__(self):
        length = 0
        curr = self.head
        while curr:
            length += 1
            curr = curr.next
        return length
