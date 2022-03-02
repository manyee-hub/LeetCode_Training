先主攻链表

public ListNode reverseKGroup(ListNode head, int k) {
    ListNode hair = new ListNode(0);
    hair.next = head;
    ListNode pre = hair;

    while (head != null) {
        ListNode tail = pre;
        // 查看剩余部分长度是否大于等于 k
        for (int i = 0; i < k; ++i) {
            tail = tail.next;
            if (tail == null) {
                return hair.next;
            }
        }
        ListNode nex = tail.next;
        ListNode[] reverse = myReverse(head, tail);
        head = reverse[0];
        tail = reverse[1];
        // 把子链表重新接回原链表
        pre.next = head;
        tail.next = nex;
        pre = tail;
        head = tail.next;
    }

    return hair.next;
}

public ListNode[] myReverse(ListNode head, ListNode tail) {
    ListNode prev = tail.next;
    ListNode p = head;
    while (prev != tail) {
        ListNode nex = p.next;
        p.next = prev;
        prev = p;
        p = nex;
    }
    return new ListNode[]{tail, head};
}

向右移动 代表
单向链表 受限于无前节点，需要特殊算法

32位系统下的“字”大小为32位（意思就是采用32位大小的整数来表示每个内存地址），所以寻址能力为2的32次方，地址范围为0 ~ 2^32 - 1
双指针法 常用于动态规划，即在一次循环中找到目标元素


计数排序
function countingSort(arr, maxValue) {
    var bucket = new Array(maxValue+1),
        sortedIndex = 0;
        arrLen = arr.length,
        bucketLen = maxValue + 1;

    for (var i = 0; i < arrLen; i++) {
        if (!bucket[arr[i]]) {
            bucket[arr[i]] = 0;
        }
        bucket[arr[i]]++;
    }

    for (var j = 0; j < bucketLen; j++) {
        while(bucket[j] > 0) {
            arr[sortedIndex++] = j;
            bucket[j]--;
        }
    }

    return arr;
}

插入排序
function insertionSort(arr) {
    var len = arr.length;
    var preIndex, current;
    for (var i = 1; i < len; i++) {
        preIndex = i - 1;
        current = arr[i];
        while (preIndex >= 0 && arr[preIndex] > current) {
            arr[preIndex + 1] = arr[preIndex];
            preIndex--;
        }
        arr[preIndex + 1] = current;
    }
    return arr;
}


配合快速排序
private static void 快速排序(int[] arr,int begin, int end){
    // 判断当前走到接近
    if(begin<end){
        int mid = 获取基准位置(arr,begin,end);
        快速排序(arr,begin,mid-1);
        快速排序(arr,mid+1,end);
    }
}

private static int 获取基准位置(int[] arr, int begin, int end){
    int mid = arr[begin];
    while(begin < end){
        while(begin < end && arr[end]>=mid) --end;
        while(begin < end && arr[begin]<=mid) ++begin;
        int temp=arr[begin];
        arr[begin] = arr[end];
        arr[end] = temp;
    }
    arr[begin] = mid;
    return begin;
}