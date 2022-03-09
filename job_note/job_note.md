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

// 归并排序 分治法
static int[] merge(int[] arr){
    int length = arr.Length;
    if(length<2) return arr;
    int mid = length >> 1;
    int[] left = arr.Skip(0).Take(mid).ToArray();
    int[] right = arr.Skip(mid).Take(length-mid).ToArray();
    return mergeSub(merge(left),merge(right));
}

static int[] mergeSub(int[] left, int[] right){
    int l = left.Length, r = right.Length, length = l + r;
    int[] result = new int[length];
    while(--length>=0){
        if(r<=0 || (l>0 && left[l-1]>right[r-1])){
            result[length] = left[l-1];
            --l;
        }else{
            result[length] = right[r-1];
            r--;
        }
    }
    return result;
}



给你一个长度为 n 的链表，每个节点包含一个额外增加的随机指针 random ，该指针可以指向链表中的任何节点或空节点。

构造这个链表的 深拷贝。 深拷贝应该正好由 n 个 全新 节点组成，其中每个新节点的值都设为其对应的原节点的值。新节点的 next 指针和 random 指针也都应指向复制链表中的新节点，并使原链表和复制链表中的这些指针能够表示相同的链表状态。复制链表中的指针都不应指向原链表中的节点 。

例如，如果原链表中有 X 和 Y 两个节点，其中 X.random --> Y 。那么在复制链表中对应的两个节点 x 和 y ，同样有 x.random --> y 。

返回复制链表的头节点。

用一个由 n 个节点组成的链表来表示输入/输出中的链表。每个节点用一个 [val, random_index] 表示：

val：一个表示 Node.val 的整数。
random_index：随机指针指向的节点索引（范围从 0 到 n-1）；如果不指向任何节点，则为  null 。
你的代码 只 接受原链表的头节点 head 作为传入参数。

检测环形结构，使用快慢指针模型 快指针一次走两步 慢指针一次走一步，快指针和慢指针会在某一时刻相遇（对象相同），说明出现环链

a+(n+1)b+nc=2(a+b)⟹a=c+(n−1)(b+c)
nb - b + nc = a
a = nb - b + nc - c + c
a = (n - 1)(b+c) + c


题目中要求找到所有「不重复」且和为 0 的三元组，这个「不重复」的要求使得我们无法简单地使用三重循环枚举所有的三元组。这是因为在最坏的情况下，数组中的元素全部为 0，即
[0, 0, 0, 0, 0, ..., 0, 0, 0]

任意一个三元组的和都为 0。如果我们直接使用三重循环枚举三元组，会得到 O(N^3) 个满足题目要求的三元组（其中 N 是数组的长度）时间复杂度至少为 O(N^3)。在这之后，我们还需要使用哈希表进行去重操作，得到不包含重复三元组的最终答案，又消耗了大量的空间。这个做法的时间复杂度和空间复杂度都很高，因此我们要换一种思路来考虑这个问题。
「不重复」的本质是什么？我们保持三重循环的大框架不变，只需要保证：
第二重循环枚举到的元素不小于当前第一重循环枚举到的元素；
第三重循环枚举到的元素不小于当前第二重循环枚举到的元素。

也就是说，我们枚举的三元组 (a, b, c) 满足 a≤b≤c，保证了只有 (a, b, c) 这个顺序会被枚举到，而 (b, a, c)、(c, b, a) 等等这些不会，这样就减少了重复。要实现这一点，我们可以将数组中的元素从小到大进行排序，随后使用普通的三重循环就可以满足上面的要求。

同时，对于每一重循环而言，相邻两次枚举的元素不能相同，否则也会造成重复。举个例子，如果排完序的数组为
[0, 1, 2, 2, 2, 3]
我们使用三重循环枚举到的第一个三元组为 (0, 1, 2)，如果第三重循环继续枚举下一个元素，那么仍然是三元组 (0, 1, 2)，产生了重复。因此我们需要将第三重循环「跳到」下一个不相同的元素，即数组中的最后一个元素 3，枚举三元组 (0, 1, 3)。

下面给出了改进的方法的伪代码实现：
nums.sort()
for first = 0 .. n-1
    // 只有和上一次枚举的元素不相同，我们才会进行枚举
    if first == 0 or nums[first] != nums[first-1] then
        for second = first+1 .. n-1
            if second == first+1 or nums[second] != nums[second-1] then
                for third = second+1 .. n-1
                    if third == second+1 or nums[third] != nums[third-1] then
                        // 判断是否有 a+b+c==0
                        check(first, second, third)
这种方法的时间复杂度仍然为 O(N^3)，毕竟我们还是没有跳出三重循环的大框架。然而它是很容易继续优化的，可以发现，如果我们固定了前两重循环枚举到的元素 a 和 b，那么只有唯一的 c 满足 a+b+c=0。当第二重循环往后枚举一个元素 b'时，由于 b' > b，那么满足 a+b'+c'=0的 c'一定有 c' < c，即 c'在数组中一定出现在 c 的左侧。也就是说，我们可以从小到大枚举 b，同时从大到小枚举 c，即第二重循环和第三重循环实际上是并列的关系。
有了这样的发现，我们就可以保持第二重循环不变，而将第三重循环变成一个从数组最右端开始向左移动的指针，从而得到下面的伪代码：

nums.sort()
for first = 0 .. n-1
    if first == 0 or nums[first] != nums[first-1] then
        // 第三重循环对应的指针
        third = n-1
        for second = first+1 .. n-1
            if second == first+1 or nums[second] != nums[second-1] then
                // 向左移动指针，直到 a+b+c 不大于 0
                while nums[first]+nums[second]+nums[third] > 0
                    third = third-1
                // 判断是否有 a+b+c==0
                check(first, second, third)
这个方法就是我们常说的「双指针」，当我们需要枚举数组中的两个元素时，如果我们发现随着第一个元素的递增，第二个元素是递减的，那么就可以使用双指针的方法，将枚举的时间复杂度从 O(N^2) 减少至 O(N)。为什么是 O(N) 呢？这是因为在枚举的过程每一步中，「左指针」会向右移动一个位置（也就是题目中的 b），而「右指针」会向左移动若干个位置，这个与数组的元素有关，但我们知道它一共会移动的位置数为 O(N)，均摊下来，每次也向左移动一个位置，因此时间复杂度为 O(N)。
注意到我们的伪代码中还有第一重循环，时间复杂度为 O(N)，因此枚举的总时间复杂度为 O(N^2)。由于排序的时间复杂度为 O(NlogN)，在渐进意义下小于前者，因此算法的总时间复杂度为 O(N^2)。
上述的伪代码中还有一些细节需要补充，例如我们需要保持左指针一直在右指针的左侧（即满足 b≤c），具体可以参考下面的代码，均给出了详细的注释。
