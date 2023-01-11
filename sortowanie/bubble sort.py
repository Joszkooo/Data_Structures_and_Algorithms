def my_bubble_sorting(arr):
    n = len(arr)

    for i in range(1, n):
        for j in range(0, n-i):
            if arr[j] > arr[j+1]:
                arr[j], arr[j+1] = arr[j+1], arr[j]


def optimized_bubble_sorting(arr):
    n = len(arr)

    while True:
        swapped = False
        for i in range(1, n):
            if arr[i - 1] > arr[i]:
                arr[i - 1], arr[i] = arr[i], arr[i - 1]
                swapped = True
        n -= 1
        if not swapped:
            break
    return arr


def verify(arr):
    flag = 0
    if arr == sorted(arr):
        flag = 1

    if flag:
        return True
    else:
        return False


def main():
    wejscie = [20, 3, 9, 0, 4]
    my_bubble_sorting(wejscie)
    # optimized_bubble_sorting(wejscie)
    verify(wejscie)
    print(wejscie)


if __name__ == "__main__":
    main()
