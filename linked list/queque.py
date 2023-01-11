from linked_list import LinkedList, Node
from typing import Any

# reprezentacja kolejki FIFO (first input, first output)
class Queue:
    _storage: LinkedList

    def __init__(self, storage=None):
        if storage is None:
            self._storage = LinkedList()
        else:
            self._storage = storage

    # zwróci wartość pierwszego elementu w kolejce
    def peek(self) -> Any:
        return self._storage.head

    # umieszcza nowy element na końcu kolejki
    def enqueue(self, element: Any) -> None:
        curr = self._storage.head
        if curr is None:
            self._storage.head = Node(element)
        else:
            while curr.next:


    # zwraca i usuwa pierwszy element w kolejce
    def dequeue(self) -> Any:
        pass

    # wypisze na ekranie jej elementy we właściwej kolejności
    def print(self):
        pass

    # zwraca liczebność kolejki
    def len(self):
        pass

def test():
    queue = Queue()
    assert len(queue) == 0
    queue.enqueue('klient1')
    queue.enqueue('klient2')
    queue.enqueue('klient3')

    assert str(queue) == 'klient1, klient2, klient3'

    client_first = queue.dequeue()

    assert client_first == 'klient1'
    assert str(queue) == 'klient2, klient3'
    assert len(queue) == 2