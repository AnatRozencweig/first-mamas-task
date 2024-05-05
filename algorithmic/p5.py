import math


def reverse_n_pi_digits(n: int) -> str:
    pi = str(math.pi)
    return pi.split(".")[1][:n][::-1]


