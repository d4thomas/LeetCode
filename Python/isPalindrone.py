class Solution:
    def isPalindrome(self, x: int) -> bool:
        string_number = str(x)
        list_number = list(string_number)
        list_reverse = []

        for i in range(len(list_number) - 1, -1, -1):
            list_reverse.append(list_number[i])

        return list_reverse == list_number

x = 121
print(Solution().isPalindrome(x))
