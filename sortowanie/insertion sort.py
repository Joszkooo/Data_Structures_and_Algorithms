def my_insertion_sort(arr):
    length = len(arr)
    for idx in range(1, length):
        value = arr[idx]
        i = idx - 1
        while i >= 0:
            if value < arr[i]:
                arr[i+1] = arr[i]
                arr[i] = value
                i -= 1
            else:
                break


def main():
    arr = [12, 11, 13, 5, 6]
    my_insertion_sort(arr)
    print(arr)


if __name__ == '__main__':
    main()