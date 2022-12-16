<template>
    <v-toolbar id="toolbar">
        <v-toolbar-side-icon @click.stop="drawer = !drawer"></v-toolbar-side-icon>
        <div class="hidden-sm-and-down">
            <v-btn flat>Home</v-btn>
            <v-btn flat>Profil</v-btn>
            <v-btn flat>Unit/Lembaga</v-btn>
            <v-btn flat>Akademik</v-btn>
            <v-btn flat>Dokumen</v-btn>
            <v-btn flat>Galeri</v-btn>
            <v-btn flat>Peta</v-btn>
            <v-btn flat>Video Profil</v-btn>
            <router-link to="/login">
                <v-btn flat>Kontak</v-btn>
            </router-link>
        </div>
        <div class="hidden-sm-and-down">
            <v-navigation-drawer v-model="drawer" absolute temporary height="800px">
                <v-list class="pa-1">
                    <v-list-item avatar>
                        <v-list-item-avatar>
                            <img src="https://randomuser.me/api/portraits/men/85.jpg">
                        </v-list-item-avatar>
                        <v-list-item-content>
                            <v-list-item-title>John Leider</v-list-item-title>
                        </v-list-item-content>
                    </v-list-item>
                </v-list>
                <v-list class="pt-0" dense>
                    <v-divider></v-divider>
                    <v-list-item 
                    v-for="item in items"
                    :key="item.title"
                    ><v-list-item-action>
                        <v-icon>{{ item.icon}}</v-icon>
                    </v-list-item-action>
                    <v-list-item-content>
                        <v-list-item-title>{{item.title}}</v-list-item-title>
                    </v-list-item-content>
                </v-list-item>
                </v-list>
            </v-navigation-drawer>
        </div>
    </v-toolbar>
</template>
<script>
export default {
    data () {
        return {
            drawer: null,
            items: [
                { title: 'Home', icon: 'mdi-dashboard'},
                { title: 'About', icon: 'mdi-question_answer'}
            ]
        }
    }
}
</script>
<style>
#toolbar {
    background-color: darkgreen;
}
.v-btn {
    background-color: darkgreen !important;
    color: white !important;
}
</style>