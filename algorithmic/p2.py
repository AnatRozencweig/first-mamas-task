def find_all_pythagorean_triples_that_make_sum(triplet_sum: int) -> list:
    pythagorean_triples_list = []
    for a in range(1, triplet_sum):
        for b in range(a, triplet_sum):
            c = triplet_sum - a - b
            if c > 0 and c ** 2 == a ** 2 + b ** 2:
                pythagorean_triples_list.append((a, b, c))
    return pythagorean_triples_list


def pythagorean_triplet_by_sum(triplet_sum: int) -> None:
    pythagorean_triples_list = find_all_pythagorean_triples_that_make_sum(triplet_sum)
    for triple in pythagorean_triples_list:
        if sum(triple) == triplet_sum:
            print(f"{triple[0]} < {triple[1]} < {triple[2]}")


pythagorean_triplet_by_sum(120)
