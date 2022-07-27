<template>
    <!--<li>-->
    <div class="group-15 border-0-4px-black">
        {{ title }}
        <!-- <keep-alive> -->
        <Userpage v-bind:title="this.title" v-bind:addnew="this.addnew"></Userpage>
        <!-- </keep-alive> -->
        <button @click="$emit('remove')" v-if="!addnew">Remove</button>
    </div>
    <!--</li>-->
</template>

<script>

    import Userpage from "./Userpage"

    export default {
        name: 'TODOITEM',
        props: ['title'],
        emits: ['remove'],
        components:
            { Userpage }
    }
</script>

<style scoped>
    .group-15 {
        -webkit-backdrop-filter: blur(15px) brightness(100%);
        backdrop-filter: blur(15px) brightness(100%);
        background-color: var(--white-32);
        border-radius: 13px;
        min-height: 139px;
        /*            left: 428px;
                position: absolute;
                top: 259px;
    */
        min-width: 197px;
        padding: 10px;
        margin: 10px;
        display: inline-block
    }
</style>
