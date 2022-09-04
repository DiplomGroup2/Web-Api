<template>

    <div class="fredoka-light-black-15px img-record">
        <span v-if="type==a1"> {{text}} </span>
        <!--<span v-if="type==a2"> <img v-bind:src="axios.defaults.baseURL+'/api/Record/GetImage?imageId=6306771b914c73fdf375d02f'" /> </span>-->
        <span class="img-record" v-if="type==a2"> <img class="img-record" v-bind:src="'http://lavira-001-site1.atempurl.com/api/Record/GetImage?imageId=' + imageId" /> </span>
    </div>

</template>


<script>
  /*  import axios from 'axios'*/

    export default {
        name: 'RECORDITEM',
        props: ['text', 'imageId', 'type'],
        //emits: ['remove'],
       // emits: ['remove', 'refresh'],


        data() {
            return {
                //message: '',
                //groups: [],
                //imgSrc: ''
                a1: 'text',
                a2: 'image',
                a3: 'Url',
                a4: 'file',
                img: 'null',
            }
        },
        async created() {

        },

        methods: {


        }
    }
</script>



<style scoped>

    .text {
        letter-spacing: 0;
        margin-top: 8px;
        min-height: 16px;
        width: 39px;
    }

    @import url("https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css");

    @import url("https://fonts.googleapis.com/css?family=Fredoka:400,300,700,500");


    .fredoka-light-black-15px {
        color: var(--black);
        font-family: var(--font-family-fredoka);
        font-size: var(--font-size-s);
        font-style: normal;
        font-weight: 300;
    }

    .img-record {
        width: 100%;
        margin: 1px;
    }
</style>