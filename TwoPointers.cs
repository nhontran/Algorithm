/*Note: Write a solution with O(n2) time complexity, since this is what you would be asked to do during a real interview.

You have an array a composed of exactly n elements. Given a number x, determine whether or not a contains three elements for which the sum is exactly x.

Example

For x = 15 and a = [14, 1, 2, 3, 8, 15, 3], the output should be
tripletSum(x, a) = false;

For x = 8 and a = [1, 1, 2, 5, 3], the output should be
tripletSum(x, a) = true.

The given array contains the elements 1,2, and 5, which add up to 8.
*/
bool tripletSum(int x, int[] a) {
    Array.Sort(a);
    for(int i = 0; i < a.Length; i++) {
        int l = i+1, r = a.Length - 1; //two pointers
        while ( l < r ) {
           if ( a[i] + a[l] + a[r] == x ) return true;
           else if ( a[i] + a[l] + a[r] > x ) r--;
           else l++;
        }
    }
    return false;
} 
