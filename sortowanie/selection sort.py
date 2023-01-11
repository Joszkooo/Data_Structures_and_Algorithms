def my_selection_sort(arr):
    """
    Nie ma sensu optymalizowac sortowania przez wybor poniewaz zlozonosc czy jak to sie mowi notacja BIG O jest taka sama:
    Best-case: O(n^2)
    Average-case: O(n^2)
    Worst-case: O(n^2)
    """
    n = len(arr)

    for idx in range(n):
        index_min = idx
        for j in range(idx+1, n):
            if arr[j] < arr[index_min]:
                index_min = j
        arr[idx], arr[index_min] = arr[index_min], arr[idx]


def main():
    arr = [-2, 45, 0, 11, -9, 88, -97, -202, 747]
    my_selection_sort(arr)
    print(arr)


if __name__ == '__main__':
    main()
