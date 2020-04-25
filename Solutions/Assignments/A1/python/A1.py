def MaximomValue(*nums):  
    result=nums[0]
    for num in nums:
        if(num>result):
            result=num
    return result
def CommonIntegerElements(nums1,nums2):
    result=[]
    for num in nums1:
        if(num in nums2):
            result.append(num)
    result.sort()
    return result

def CommonStringElements(str1,str2):
    result=[]
    for string in str1:
        if(string in str2):
            result.append(string)
    result.sort()
    return result

def CommonElements(set1,set2):
    result=[]
    for element in set1:
        if(element in set2):
            result.append(element)
    return result
