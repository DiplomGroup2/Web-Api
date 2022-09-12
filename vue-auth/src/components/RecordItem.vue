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
        <!--ДИСКЕТА C ПОЛЕМ ДЛЯ ВЫВОДА ИНФЫ-->
        <!--виведення файлу-->
        <span v-if="type==a4" class="group-file">
            <span class="group-135" >
                <span class="overlap-group3">
                    <span class="overlap-group-1">
                        <span class="rectangle-134"></span>
                    </span>
                    <span class="rectangle-132"></span>
                </span>
            </span>
            <span class="rectangle-135">
                <a v-bind:href="'http://lavira-001-site1.atempurl.com/api/Record/GetFile?imageId=' + imageId" target="_blank">{{message}} </a>
                <!--<a v-bind:href="'http://localhost:59723/api/Record/GetFile?imageId=' + imageId" target="_blank">{{message}} </a>-->
            </span>
        </span>

        <!--ДИСКЕТА C ПОЛЕМ ДЛЯ ВЫВОДА ИНФЫ - базовый вариант
        <a href="zametka-2.html">
            <div class="group-135">
              <div class="overlap-group3">
                <div class="overlap-group-1">
                  <div class="rectangle-134"></div>
                </div>
                <div class="rectangle-132"></div>
              </div></div
          ></a>
          <div class="rectangle-135"></div>-->
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
    .group-file {
        align-items: stretch;
        cursor: pointer;
        display: flex;
        flex-direction: row;
        width: 100%;
        padding: 4px;
        border-color: var(--black);
        border-radius: 5px;
        padding: 5px;
        margin: 5px;
    }

    .group-135 {
        align-items: flex-start;
        cursor: pointer;
        width: 40px;
        padding: 7px;
    }

    .rectangle-135 {
        border: 0.5px solid;
        border-color: gray;
        border-radius: 5px;
        width: 100%;
        padding: 5px;
    }

    .overlap-group3 {
        align-items: flex-start;
        background-image: url(../assets/vector-10@2x.svg);
        background-size: 100% 100%;
        display: flex;
        flex-direction: column;
        margin-bottom: -0.35px;
        min-height: 15px;
        padding: 0.1px 2.9px;
        width: 17px;
    }

    .overlap-group-1 {
        align-items: flex-start;
        border: 0.7px solid;
        border-color: var(--gray);
        border-radius: 0.5px;
        display: flex;
        height: 7px;
        justify-content: flex-end;
        margin-left: 1.64px;
        min-width: 8px;
        padding: 1.1px 2.0px;
    }

    .rectangle-134 {
        background-color: var(--gray);
        border: 1px none;
        height: 3px;
        width: 2px;
    }

    .rectangle-132 {
        border: 0.7px solid;
        border-color: var(--gray);
        border-radius: 0.5px;
        height: 5px;
        margin-top: 1px;
        width: 11px;
    }

    #textArea {
        resize: both;
        width: 100%;
        height: 100%;
    }

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