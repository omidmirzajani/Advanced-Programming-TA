/*
 * This Java source file was generated by the Gradle 'init' task.
 */
package A1;
import java.util.ArrayList;

public class Program {
    public static int MaximumValue(int... nums){
        int max_Val = nums[0];
        for(int i : nums)
            if(i>max_Val)
                max_Val=i;
        return max_Val;
    }
    public static void sort_Nums(Integer[] result){
        for(int i=0; i<result.length-1; i++){
            for(int j=i+1; j<result.length; j++){
                if(result[i]>result[j]){
                    Integer hold = result[i];
                    result[i] = result[j];
                    result[j] = hold;
                }
            }
        }
    }
    public static Integer[] CommonIntegerElements(Integer[]nums1, Integer[]nums2){
        Integer[]nums3; Integer[]nums4; ArrayList<Integer>result = new ArrayList<Integer>();
        if(nums1.length>nums2.length){
            nums3=nums1; nums4=nums2;
        }
        else{
            nums3=nums2; nums4=nums1;
        }
        for(int i : nums3){
            for(int j : nums4){
                if(i==j)
                    result.add(i);                    
            }
        }
        Integer[] nums5 = new Integer[result.size()];
        nums5 = result.toArray(nums5);
        sort_Nums(nums5);
        return nums5;
    }

    public static String[] CommonStringElements(String[]str1, String[]str2){
        var result = new ArrayList<String>(); String[]str3; String[]str4;
        if(str1.length>str2.length){
            str3 = str1; str4 = str2;
        }else{
            str3 = str2; str4=str1;
        }
        for(String i : str3)
            for(String j : str4)
                if(i==j)
                    result.add(i);
        String[] result2 = new String[result.size()];
        result2 = result.toArray(result2);
        sort_String(result2);
        return result2;
    }

    private static void sort_String(String[] result2) {
        char[] str1 ; char[] str2;
        for(int i=0; i<result2.length-1; i++){
            str1 = result2[i].toCharArray(); str2 = result2[i+1].toCharArray();
            for(int j=0; j<str1.length; j++){
                if((j+1==str1.length || j+1==str2.length)&&(str1[j]>str2[j])){
                    String tmp = result2[i];
                    result2[i] = result2[i+1];
                    result2[i+1] = tmp;
                    break;
                } else if(str1[j]>str2[j]) {
                    String tmp = result2[i];
                    result2[i] = result2[i+1];
                    result2[i+1] = tmp;                        
                } else if(str1[j]==str2[j]) {
                    continue;
                } else {
                    break;
                }
            }
            
        }
    }
    public static <_Type> ArrayList<_Type> CommonElements(_Type[] arr1, _Type[] arr2){
        var result = new ArrayList<_Type>();
        for(var i : arr1){
            for(var j : arr2){
                if(i==j){
                    result.add(i);
                }
            }
        }
        return result;
    }
    public String getGreeting() {
        return "Hello world.";
    }
    public static void main(String[] args) {
        System.out.println(new Program().getGreeting());
    }

}
 