<template>
    <!--<img class="group-136" src="../assets/group-136-2@2x.svg" />-->
    <div class="fredoka-light-black-15px img-record">
        <!--виведення тексту з можливістю редагування-->
        <span v-if="type==a1">
            <span v-if="!editing" v-on:click="edit()" style="white-space: pre-line">
                {{message}}
            </span>
            <span v-if="editing">
                <textarea id="textArea" v-model="message" v-on:blur="save_record" />

            </span>
        </span>

        <!--виведення зображення-->
        <span class="img-record" v-if="type==a2"> <img class="img-record" v-bind:src="'http://lavira-001-site1.atempurl.com/api/Record/GetImage?imageId=' + imageId" /> </span>

        <!--виведення посилання-->
        <span v-if="type==a3">
            <span v-if="!editing" v-on:click="edit()">
                <a v-bind:href="message" target="_blank">{{message}} </a>
            </span>
            <span v-if="editing">
                <textarea id="textArea" v-model="message" v-on:blur="save_record" />

            </span>
        </span>


        <!--<a href="screen.html"><img class="group-136" src="assets/group-136@2x.svg" /> </a>-->

    </div>

</template>


<script>
    import axios from 'axios'

    export default {
        name: 'RECORDITEM',
        props: ['text', 'imageId', 'type', 'recordId', 'pageId'],
        //emits: ['remove'],
        // emits: ['remove', 'refresh'],


        data() {
            return {
                message: '',
                //groups: [],
                //imgSrc: ''
                a1: 'text',
                a2: 'image',
                a3: 'url',
                a4: 'file',
                img: 'null',
                editing: false,
            }
        },
        async created() {
            this.message = this.text;
        },

        methods: {
            edit() {
                this.editing = true;
            },

            async save_record() {
                try {
                    await axios.put('api/Record/Edit',
                        {
                            Text: this.message,
                            IdRecord: this.recordId,
                            pageId: this.pageId,
                        }, {
                        headers: {
                            'Authorization': `Bearer ${localStorage.getItem('access_token')}`
                        }
                    });

                } catch (e) {
                    this.error = 'Invalid!';
                    console.log(e);
                }
                this.editing = false;
                //alert(
                //    this.message);
            },

        }
    }
</script>



<style scoped>
    group-136 {
        height: 21px;
        margin-bottom: 0;
        margin-left: 10px;
        width: 21px;
    }

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