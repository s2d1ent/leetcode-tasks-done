public class ProductOfNumbers {
    List<int> arr = new List<int>();
    public ProductOfNumbers() {}
    public void Add(int num) {
        arr.Add(num);
    }
    public int GetProduct(int k) {
        int result = 1;
        for(var i = arr.Count - 1; i > arr.Count-1-k; i--)
            result*=arr[i];
        return result;
    }
}