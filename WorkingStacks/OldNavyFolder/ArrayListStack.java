//----------------------------------------------------------------------
// ArrayListStack.java        by Dale/Joyce/Weems              Chapter 2
//
// Implements an unbounded stack using an ArrayList.
//----------------------------------------------------------------------

import java.util.ArrayList; 

public class ArrayListStack<T> implements StackInterface<T>
{
  protected ArrayList<T> elements; // ArrayList that holds stack elements

  public ArrayListStack() 
  {
    elements = new ArrayList<T>(25);      
  }

  public void push(T element)   
  // Places element at the top of this stack.
  {
    elements.add(element);
  }

  public void pop()               
  // Throws StackUnderflowException if this stack is empty,
  // otherwise removes top element from this stack.
  {
    if (isEmpty())
      throw new StackUnderflowException("Pop attempted on an empty stack.");
    else 
      elements.remove(elements.size() - 1);
  }

  public T top()             
  // Throws StackUnderflowException if this stack is empty,
  // otherwise returns top element of this stack.
  {
    T topOfStack = null;
    if (isEmpty())
      throw new StackUnderflowException("Top attempted on an empty stack.");    
    else 
      topOfStack = elements.get(elements.size() - 1);
    return topOfStack;
  }

  public boolean isEmpty()         
  // Returns true if this stack is empty, otherwise returns false.
  {
    return (elements.size() == 0);
  }
  
  public boolean isFull()
  // Returns false - an ArrayList stack is never full.
  {              
    return false;
  }
  
  public int size() {
	  return elements.size();
  }
  
  public void popSome(int count) {
	  if(elements.size() < count) {
		  throw new StackUnderflowException("Pop attempted on a stack with less than count");
	  }
	  for(int i=0; i < count; i++) {
		  this.pop();
	  }
  }
  
  public boolean swapStart() {
	  if(elements.size() < 2) {
		  return false;
	  }
	  else {
		  elements.set(elements.size()-1, elements.get(elements.size()-2));
		  elements.set(elements.size()-2, elements.get(elements.size()-1));
		  return true;
	  }
  }
  
  public boolean swapEnd() {
	  if(elements.size() < 2) {
		  return false;
	  }
	  else {
		  elements.set(0, elements.getLast());
		  elements.set(elements.size(), elements.getFirst());
		  return true;
	  }
  }
  public T popTop() {
		  if(isEmpty())
			  throw new StackUnderflowException("Pop attempted on a stack with less than count");
		  else {
			  T top = elements.set(0, null);
			  return top;
		  }
  }

  @Override
  public String toString() {
	return " " + (elements != null ? "elements=" + elements : " ");
  }

}