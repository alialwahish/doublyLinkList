namespace DLL
{

    public class DblLnkLst
    {
        public Node head;

        public void add(int val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                this.head = newNode;
            }

            else
            {
                Node itr = this.head;
                while (itr.next != null)
                {
                    itr = itr.next;
                }
                itr.next = newNode;
                Node tempPrev = itr;
                itr.next.prev = tempPrev;




            }
        }

        public bool remove(int val)
        {
            Node itr = this.head;
            if (val == itr.value && itr.next == null)
            {
                itr = null;
                return true;
            }
            else if (val == itr.value && itr.next != null)
            {
                this.head = itr.next;
                this.head.prev = null;
                itr = null;
                return true;
            }

            while (itr.next != null)
            {
                if (itr.value == val)
                {
                    itr.prev.next = itr.next;
                    itr.next.prev = itr.prev;
                    itr = null;
                    return true;
                }
                itr = itr.next;
            }
            if (itr.value == val)
            {
                itr.prev.next = null;
                itr = null;
                return true;
            }
            return false;


        }
        public void reverse()
        {
            Node itr = this.head;
            while (itr.next != null)
            {
                itr = itr.next;
            }
            Node revItr=itr;


             while(itr.prev!=null){
                revItr.next=itr.prev;   
                itr=itr.prev;

            }

        }


    }



}