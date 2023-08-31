Module Module1

    Dim maxSize As Integer = 10
        Dim queueArray(maxSize - 1) As Integer
        Dim front As Integer = 0
        Dim rear As Integer = -1
        Dim itemCount As Integer = 0

        Sub Enqueue(item As Integer)
            If itemCount < maxSize Then
                If rear = maxSize - 1 Then
                    rear = -1
                End If

                rear += 1
                queueArray(rear) = item
                itemCount += 1
            Else
                Console.WriteLine("Queue is full")
            End If
        End Sub

        Function Dequeue() As Integer
            If itemCount > 0 Then
                Dim item As Integer = queueArray(front)
                front += 1

                If front = maxSize Then
                    front = 0
                End If

                itemCount -= 1
                Return item
            Else
                Console.WriteLine("Queue is empty")
                Return -1 ' or throw an exception
            End If
        End Function



        Sub Main()
        Enqueue(10)
        Enqueue(20)
        Enqueue(30)

        Console.WriteLine("Dequeued: " & Dequeue()) ' Output: 10
        Console.WriteLine("Dequeued: " & Dequeue()) ' Output: 20
    End Sub

End Module
