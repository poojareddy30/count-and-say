class Solution:
    def countAndSay(self, n: int) -> str:
        s='1'
        for i in range(n-1):
            count=0;
            tmpcount=0;
            t=[]
            c=s[0]
            for j in s:
                if (c==j):
                    count=count+1;
                    tmpcount=tmpcount+1;
                else:
                    count=1;
                    t.append(str(tmpcount));
                    t.append(str(c));
                    c=j
                    tmpcount=1;
            t.append(str(tmpcount));
            t.append(str(j));
            s=''.join(t)
            print(s)
        return s
        
