

<script>

import Userpage from "./Userpage"

export default {
  name:'TODOITEM',
	props: ['title'],
  emits: ['remove'],
  components:
  {Userpage}
}
</script>

<template>
  <li>
    {{ title }}
      <!-- <keep-alive> -->
      <Userpage  v-bind:title="this.title"></Userpage>
    <!-- </keep-alive> -->
    <button @click="$emit('remove')">Remove</button>
  </li>
</template>