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