<script>
import TodoItem from './TodoItem'
//import Userpage from './Userpage'
  
export default {

  name:'SP',
  components: { TodoItem },
  
  data() {
    return {
      newTodoText: '',
      todos: [
        {
          id: 1,
          title: 'Userpage1'
        },
        {
          id: 2,
          title: 'Userpage2'
        },
        {
          id: 3,
          title: 'Userpage3'
        }
      ],
      nextTodoId: 4
    }
  },
  methods: {
    addNewTodo() {
      this.todos.push({
        id: this.nextTodoId++,
        title: this.newTodoText
      })
      this.newTodoText = ''
    }
  }
}
</script>


<template>
	<form v-on:submit.prevent="addNewTodo">
    <label for="new-todo">Add a todo</label>
    <input
      v-model="newTodoText"
      id="new-todo"
      placeholder="E.g. Feed the cat"
    />
    <button>Add</button>
  </form>
  <ul>
    <todo-item
      v-for="(todo) in todos"
      :title="todo.title"
      :key="todo.id"
     
      
      @remove= "todos.splice(index, 1)"
    ></todo-item>
  </ul>
</template>