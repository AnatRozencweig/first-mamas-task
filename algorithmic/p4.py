import matplotlib.pyplot as plt
import numpy as np


def input_numbers_series() -> list:
    input_num = 0
    input_number_list = []
    while input_num != -1:
        input_num = float(input("enter number (to finish enter -1): "))
        input_number_list.append(input_num)
    input_number_list.remove(-1)
    return input_number_list


def calc_list_average(numbers_list: list) -> float:
    sum = 0
    numbers_amount = len(numbers_list)
    for num in numbers_list: sum += num
    return sum / numbers_amount


def calc_positive_numbers_amount(numbers_list: list) -> int:
    positive_numbers_amount = 0
    for num in numbers_list:
        if num > 0:
            positive_numbers_amount += 1
    return positive_numbers_amount


def show_chosen_numbers_series_details() -> None:
    input_number_list = input_numbers_series()
    try:
        print(f"The numbers series average: {calc_list_average(input_number_list)}")
        print(f"The amount of positive numbers in the series: {calc_positive_numbers_amount(input_number_list)}")
        input_number_list.sort()
        print(f"The sorted numbers series: {input_number_list}")
    except:
        print("it seems like you didn't entered numbers yet")


def show_chosen_numbers_graph(numbers_list: list) -> None:
    ypoints = np.array(numbers_list)
    plt.plot(ypoints, marker='o')
    plt.show()


show_chosen_numbers_graph(input_numbers_series())
