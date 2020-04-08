import java.util.*;
import java.io.*; 
import java.util.List; 
import java.util.ArrayList; 

public class Main {
    static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {
        
    }

    public static int MaximumValue(Integer... nums)
    {
        int result=nums[0];
        for(int i=1;i<nums.length;i++)
        {
            if(nums[i]>result)
                result=nums[i];
        }
        return result;
    }

    public static Integer[] CommonIntegerElements (Integer[] nums1, Integer[] nums2) {
        ArrayList<Integer> res = new ArrayList<>();
        for (Integer x : nums1) {
            boolean flag = false;
            for (Integer y : nums2) {
                if (x == y) flag = true;
            }
            if (flag) res.add(x);
        }
        Collections.sort(res);
        Integer[] result = new Integer[res.size()];
        for (int i = 0; i < res.size(); ++i) {
            result[i] = res.get(i);
        }
        return result;
    }
    
    public static String[] CommonStringElements (String[] str1, String[] str2) {
        ArrayList<String> res = new ArrayList<>();
        for (String x : str1) {
            boolean flag = false;
            for (String y : str2) {
                if (x == y) flag = true;
            }
            if (flag) res.add(x);
        }
        Collections.sort(res);
        String[] result = new String[res.size()];
        for (int i = 0; i < res.size(); ++i) {
            result[i] = res.get(i);
        }
        return result;
    }
    
    public static <T> ArrayList<T> CommonElements (T[] str1, T[] str2) {
        ArrayList<T> res = new ArrayList<>();
        for (T x : str1) {
            boolean flag = false;
            for (T y : str2) {
                if (x == y) flag = true;
            }
            if (flag) res.add(x);
        }
        
        return res;
    }
    
    

}