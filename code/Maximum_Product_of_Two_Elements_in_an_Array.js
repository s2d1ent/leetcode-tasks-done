var maxProduct = function(nums) { 
    let arr=nums.sort(function(a, b) {
     return b - a;
   });  
   return (arr[0]-1)*(arr[1]-1);  
}; 