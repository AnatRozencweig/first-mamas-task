def is_polyndrom(text: str) -> bool:
    return text == text[::-1]


def is_half_text_sorted(text: str) -> bool:
    half_text = text[:int(len(text) / 2) + 1]
    sorted_half_text = ''.join(sorted(half_text))
    return half_text == sorted_half_text


def is_sorted_polyndrom(text):
    return is_polyndrom(text) and is_half_text_sorted(text)
