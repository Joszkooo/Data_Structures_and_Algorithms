from typing import Any, List


class BinaryNode:

    def __init__(self, value: Any, left_child=None, right_child=None):
        self.value = value
        self.left_child = left_child
        self.right_child = right_child

    # zwróci węzeł z najmniejszą wartością biorąc pod uwagę siebie i swoich potomków
    def min(self) -> 'BinaryNode':
        pass


class BinarySearchTree:

    def __init__(self):
        self.root = None

    # dodaje nowy węzeł wywołując metodę prywatną _insert, a następnie zwróci nową
    def insert(self, value: Any) -> None:
        if self.root is None:
            self.root = BinaryNode(value)
        else:
            self._insert(self.root, value)

    # dodaje nowy węzeł
    def _insert(self, node: BinaryNode, value: Any) -> None:
        if value < node.value:
            if node.left_child is None:
                node.left_child = BinaryNode(value)
            else:
                self._insert(node.left_child, value)

        elif value > node.value:
            if node.right_child is None:
                node.right_child = BinaryNode(value)
            else:
                self._insert(node.right_child, value)

        else:
            print('Value already in the tree')

    # dodaje seryjnie wiele węzłów do drzewa za pomocą wielokrotnego
    # wywoływania metody insert
    def insert_list(self, list_: List[Any]) -> None:
        for element in list_:
            self.insert(element)

    # sprawdza czy w drzewie znajduje się węzeł o wskazanej wartości
    def contains(self, value: Any) -> bool:
        if self.root is not None:
            self._contains(value, self.root)
        else:
            return False

    def _contains(self, value, node):
        if value == node.value:
            return True
        elif value < node.value and node.left_child is not None:
            return self._contains(value, node.left_child)
        elif value > node.value and node.right_child is not None:
            return self._contains(value, node.right_child)
        return False

    # usunie węzeł z drzewa wywołując metodę prywatną _remove, a następnie zwróci
    # nową strukturę drzewa i ustawi ją jako korzeń
    def remove(self, value: Any) -> None:
        if value is None or self.contains(value) is None:
            print("Value to be deleted not found in the tree!")
            return None
        else:


    # usunie węzeł node albo jego potomka
    def _remove(self, node: BinaryNode, value: Any):

        def num_of_children(node):
            num_children = 0
            if node.left_child is not None: num_children += 1
            if node.right_child is not None: num_children += 1
            return num_children

        node_children = num_of_children(node)

        # CASE 1 (node has no children)
        if node_children == 0:
            if value == node.value:
                node_parent.left_child = None
            else:
                node_parent.right_child = None

        # CASE 2 (node has a single child)
        if node_children == 1:
            pass

        # CASE 3 (node has two children)
        if node_children == 2:
            pass

    @staticmethod
    def show() -> None:
        pass
