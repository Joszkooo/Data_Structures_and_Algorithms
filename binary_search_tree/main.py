from my_bst import BST


def fill_tree_random(tree, num_elements=100, max_int=1000):
    from random import randint
    for _ in range(num_elements):
        cur_elem = randint(0, max_int)
        tree.insert(cur_elem)
    return tree


def main():
    tree = BST()
    # tree = fill_tree_random(tree)
    tree.insert(5)
    tree.insert(4)
    tree.insert(6)
    tree.insert(10)
    tree.insert(9)
    tree.insert(11)

    tree.print_tree()
    print()

    tree.delete_value(5)
    tree.print_tree()
    print()

    tree.delete_value(4)
    tree.print_tree()
    print()

    tree.delete_value(11)
    tree.print_tree()
    print()

    tree.delete_value(9)
    tree.print_tree()
    print()

    # print(f'my tree height is: {tree.height()}')
    # print(f'search: {tree.search(10)}')
    # print(f'search: {tree.search(30)}')


if __name__ == '__main__':
    main()
