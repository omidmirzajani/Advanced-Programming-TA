#include<stdlib.h>
#include<string.h>
#include<vector>
#include <bits/stdc++.h> 
using namespace std;

namespace A1
{
    constexpr int MaximomValueImpl(int a, int b)
    {
        return a > b ? a : b;
    }

    template<typename ArgA, typename ArgB, typename Func>
    constexpr auto foldl(Func func, ArgA a, ArgB b)
    {
        return func(a, b);
    }

    template<typename ArgA, typename ArgB,
        typename Func, typename ...Args>
        constexpr auto foldl(Func func, ArgA a, ArgB b, Args... args)
    {
        return foldl(func, func(a, b), args...);
    }

    template<typename ...Args>
    constexpr auto MaximomValue(Args... args)
    {
        return foldl(MaximomValueImpl, args...);
    }

    bool findInt(int nums[],int numsLength,int v){
        for(int i=0;i<numsLength;i++)
            if(nums[i]==v)
                return true;
        return false;
    }
    vector<int> CommonIntegerElements(int nums1[] , int nums2[],int nums1Length,int nums2Length){
        sort(nums1, nums1+nums1Length); 
        sort(nums2, nums2+nums2Length); 
        vector<int> result;  
        for(int i=0;i<nums1Length;i++){
            if(findInt(nums2,nums2Length,nums1[i]))
                result.push_back(nums1[i]);
        }
        return result;
    }

    bool findString(string nums[],int numsLength,string v){
        for(int i=0;i<numsLength;i++)
            if(nums[i]==v)
                return true;
        return false;
    }
    vector<string> CommonStringElements(string str1[] , string str2[],int str1Length,int str2Length){
        sort(str1, str1+str1Length); 
        sort(str2, str2+str2Length); 
        vector<string> result;  
        for(int i=0;i<str1Length;i++){
            if(findString(str2,str2Length,str1[i]))
                result.push_back(str1[i]);
        }
        return result;
    }

    template <typename T>
    bool findmy(T nums[],int numsLength,T v){
        for(int i=0;i<numsLength;i++)
            if(nums[i]==v)
                return true;
        return false;
    }
    template <typename T> 
    vector<T> CommonElements(T set1[] , T set2[],int set1Length,int set2Length){
        vector<T> result;  
        for(int i=0;i<set1Length;i++){
            if(findmy(set2,set2Length,set1[i]))
                result.push_back(set1[i]);
        }
        return result;
    }


}