# this function find all pythagorean triples whose three numbers are less than the maximum
def find_all_pythagorean_triples_until_max(max_num: int) -> list:
    pythagorean_triples_list = []
    n = 2
    while n * 3 < max_num and n * 4 < max_num and n * 5 < max_num:
        pythagorean_triples_list.append((3 * n, 4 * n, 5 * n))
        n += 1
    return pythagorean_triples_list


def pythagorean_triplet_by_sum(sum: int) -> None:
    pythagorean_triples_list = find_all_pythagorean_triples_until_max(sum)
    for triple in pythagorean_triples_list:
        if triple[0] + triple[1] + triple[2] == sum:
            print(f"{triple[0]} < {triple[1]} < {triple[2]}")


pythagorean_triplet_by_sum()
