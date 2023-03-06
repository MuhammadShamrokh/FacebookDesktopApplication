using System;
using System.Collections.Generic;

namespace LogicEngine
{
    public class FacebookComponentsArraySorter
    {
        private Func<IFacebookComponent, IFacebookComponent, bool> m_TestMethod;

        public Func<IFacebookComponent, IFacebookComponent, bool> Test
        {
            set
            {
                if (value != null)
                {
                    m_TestMethod = value;
                }
                else
                {
                    throw new Exception("Test method cant be null");
                }
            }
        }

        public void MergeSortArray(List<IFacebookComponent> io_ArrayToSort, int i_Left, int i_Right)
        {
            int middle;

            if (i_Left < i_Right)
            {
                middle = i_Left + (i_Right - i_Left) / 2;
                MergeSortArray(io_ArrayToSort, i_Left, middle);
                MergeSortArray(io_ArrayToSort, middle + 1, i_Right);
                mergeArray(io_ArrayToSort, i_Left, middle, i_Right);
            }
        }

        private void mergeArray(List<IFacebookComponent> io_ArrayToSort, int i_Left, int i_Middle, int i_Right)
        {
            int leftArrayLength = i_Middle - i_Left + 1;
            int rightArrayLength = i_Right - i_Middle;
            IFacebookComponent[] leftTempArray = new IFacebookComponent[leftArrayLength];
            IFacebookComponent[] rightTempArray = new IFacebookComponent[rightArrayLength];
            int i, j, k;

            for (i = 0; i < leftArrayLength; ++i)
            {
                leftTempArray[i] = io_ArrayToSort[i_Left + i];
            }

            for (j = 0; j < rightArrayLength; ++j)
            {
                rightTempArray[j] = io_ArrayToSort[i_Middle + 1 + j];
            }

            i = 0;
            j = 0;
            k = i_Left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (m_TestMethod(leftTempArray[i], rightTempArray[j]))
                {
                    io_ArrayToSort[k++] = leftTempArray[i++];
                }
                else
                {
                    io_ArrayToSort[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                io_ArrayToSort[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                io_ArrayToSort[k++] = rightTempArray[j++];
            }
        }
    }
}